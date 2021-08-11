
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using observer.Classes;
using observer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace observer
{
    public partial class Observer : Form
    {
        #region Campos Globais
        static public List<Aplicativo> Apps=null;
        public List<AplicativoJson> ArqConfig = null;
        static public int AppAtual;      
        static public TimeSpan TSdefault = new TimeSpan(0,0,20);
        static int UmSegundo = 1000;
        static int Time_Sleep = UmSegundo*10;
        static int Time_WaitOpen = UmSegundo*2;
        static string ServerName="";
        static bool Atividade = false;
        static bool MonitorarAPI = false;
        #endregion

        #region Eventos
        public Observer()
        {
            InitializeComponent();
            ofdCaminhoApp.Filter = "Executavél (*.EXE)|*.EXE";
        }

        private void Observer_FormClosing(object sender, FormClosingEventArgs fc)
        {
            if (Atividade || MonitorarAPI)
            {
                var msg = "Observer fechado de maneira incorreta ou inesperada.";
                Registra(msg);
                EmailStatus e = new EmailStatus();
                e.Lista = File.ReadAllText("Emails.txt").Split(';').ToList();
                EnviarEmail(e, msg, "Observer - Fechamento");
            }
            else
                Registra("Aplicação fechada.");
        }
        private void cbAPI_CheckedChanged(object sender, EventArgs e)
        {
            IniciarMonitoramento();
        }   
        private void bttStartarTodos_Click(object sender, EventArgs e) { try { bttRemover.Enabled = false; Start(); IniciarMonitoramento(); Registra("Monitoramento e Processo(s) Iniciado(s)!"); AppAtual = -1; } catch (Exception z) { Mensagem("Erro! "+z.Message); } }
        private void bttCarregar_Click(object sender, EventArgs e) { try { Carregar(); Mensagem("Dados Carregados!"); } catch (Exception) { Mensagem("Erro ao Carregar Dados!"); } }
        private void cmbSelecionarProcess_SelectedIndexChanged(object sender, EventArgs e){ try {SetItemApp();} catch (Exception) {  } }
        private void bttAbrir_Click(object sender, EventArgs e) 
        {
            if (AppAtual < 0)
                Mensagem("Selecione um App");
            else            
                try {  AbrirApp(); } catch (Exception) { Mensagem("Erro ao Abrir!"); }       
        }
        private void bttAjuda_Click(object sender, EventArgs e) { try { Process.Start("Ajuda.pdf"); } catch (Exception i) { Mensagem("Erro:" + i.Message); } }
        private void bttFechaApp_Click(object sender, EventArgs e)/* Ação do Botão 'Fechar'*/{ try { FechaApp(); Mensagem("Fechado!"); } catch (Exception) { Mensagem("Erro ao Fechar!"); } }
        private void bttAddprogram_Click(object sender, EventArgs e)/* Ação do Botão 'Adicionar novo App'*/
        {
            if (ofdCaminhoApp.ShowDialog() == DialogResult.OK)
                AdicionaPrograma(ofdCaminhoApp.FileName);
        }
        private void Observer_Load(object sender, EventArgs e) { try { OptionsUser(); Registra("Aplicação aberta."); } catch (Exception) { Mensagem("Erro ao Gravar em disco!"); }}
        private void bttExcluir_Click(object sender, EventArgs e) { try { Excluir(); Mensagem("Excluído!"); } catch (Exception) { Mensagem("Erro ao Excluir!"); } }
        private void bttSalvar_Click(object sender, EventArgs e) { try { Salvar(); Mensagem("Configuração Salva Com Sucesso!"); } catch (Exception) { Mensagem("Erro ao Salvar!"); } }
        private void bttAbrirLog_Click(object sender, EventArgs e)
        {
            try { Process.Start("Explorer", "Logs"); }
            catch (Exception) { MessageBox.Show("Erro ao Processar Ação!"); }
        }
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            ServerName = txtServer.Text;
        }
        private void bttFinalizarApp_Click(object sender, EventArgs e) { FinalizarApp();}
        private void bttRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbSelecionarProcess.Text);
            try { cmbSelecionarProcess.Items.Remove(cmbSelecionarProcess.SelectedItem); } catch (Exception) { }
        }
        #endregion

        #region Métodos

        void FinalizarApp()
        {
            try
            {
                MonitorarAPI = false;
                if (Apps != null)
                    for (int i = 0; i < Apps.Count; i++)
                    {
                        Apps[i].Ativo = false;
                        Apps[i].Processo.Kill();
                    }
            }
            catch (Exception) { }
            Close();
        }
        void OptionsUser()
        {
            /*Cria a pasta de log caso ela ainda nao tenha sido criada*/           
            string folder = "Logs"; 
            if (!Directory.Exists(folder))                            
                Directory.CreateDirectory(folder);

            if (!File.Exists("Email_Sender.txt"))
            {
                string login = Interaction.InputBox("Informe Email de Envio:");
                string senha = Interaction.InputBox("Informe a Senha do Email:");
                File.WriteAllText("Email_Sender.txt", login+";"+senha);
            }
            else
                txtServer.Text = File.ReadAllText("ServerName.txt");

            if (!File.Exists("ServerName.txt"))
            {
                txtServer.Text = Interaction.InputBox("Informe o nome do Servidor:");
                File.WriteAllText("ServerName.txt", txtServer.Text);
            }
            else
                txtServer.Text = File.ReadAllText("ServerName.txt");
        }
        void Excluir()
        {
            FechaApp();
            Apps.RemoveAt(AppAtual);
            cmbSelecionarProcess.Items.RemoveAt(cmbSelecionarProcess.SelectedIndex);
        }
        void IniciarMonitoramento()
        {
            try
            {
                MonitorarAPI = cbAPI.Checked;

                if (MonitorarAPI)
                    new Thread(Monitorar).Start();
                else
                    MonitorarAPI = false;

            }
            catch (Exception) { }
        }
        static void Monitorar()
        {
            StreamReader file = new StreamReader(@"ConsultaMonitoramento.txt");

            string Consulta = file.ReadLine();
            int Tempo = int.Parse(file.ReadLine());
            bool tentarNovamente = true;
            file.Close();
            EmailStatus e = new EmailStatus();
            e.Lista = File.ReadAllText("Emails.txt").Split(';').ToList();
            var msg = string.Format("ATENÇÃO! Monitoramento Iniciado, a consulta: {0} será realizada a cada {1} segundos. ", Consulta, Tempo);
            var msgb = "Observer - Inicio de Monitoramento da API";
            EnviarEmail(e, msg,msgb);
            Registra(msg+msgb);

            try
            {
                while (MonitorarAPI)
                {
                    var r = new WebClient().DownloadString(Consulta);

                    if (!r.Contains("Sucesso"))
                    {
                        if (tentarNovamente)
                            tentarNovamente = false;
                        else
                        {                          
                            EnviarEmail(e, "ATENÇÃO! Falha na consulta de monitoramento", "Observer - Erro Em Console.exe");
                            MonitorarAPI = false;
                        }
                    }
                    else
                        tentarNovamente = true;

                    Thread.Sleep(UmSegundo * Tempo);
                }
            }
            catch (Exception ex) 
            {               
                EnviarEmail(e, "ATENÇÃO! Falha na consulta de monitoramento\n"+ex.Message, "Observer - Erro(Catch) Em Console.exe");
                MonitorarAPI = false;
            }
        }
        void SetItemApp()
        {
            AppAtual = int.Parse(cmbSelecionarProcess.Text.Split('|')[1].Trim());
        }
        void ConfigAdd()
        {
            ArqConfig = new List<AplicativoJson>();
            foreach (var i in Apps)
            {
                ArqConfig.Add(new AplicativoJson()
                {
                    Ativo = i.Ativo,
                    CaseCrashApp = i.CaseCrashApp,
                    ReOpen = i.ReOpen,
                    Diretorio = i.Diretorio,
                    Nome = i.Nome,
                    Email = i.Email,
                    Log = i.Log
                });
            }
        }
        void FechaApp()
        {         
            Apps[AppAtual].Ativo=false;
        }
        void Carregar()
        {         
            Apps = new List<Aplicativo>();
            Aplicativo aplicativo = null;
            StreamReader reader = new StreamReader("Config.JSON");
            cmbSelecionarProcess.Items.Clear();
            ArqConfig = JsonConvert.DeserializeObject<List<AplicativoJson>>(reader.ReadToEnd());
            foreach (var arq in ArqConfig)
            {
                aplicativo = new Aplicativo();
                aplicativo.Nome = arq.Nome;
                aplicativo.Processo = new Process();
                aplicativo.Processo.StartInfo.FileName = arq.Diretorio;
                aplicativo.Log = arq.Log;
                aplicativo.CaseCrashApp = arq.CaseCrashApp;
                aplicativo.ReOpen = arq.ReOpen;
                aplicativo.Email = arq.Email;
                aplicativo.Ativo = true;
                aplicativo.Diretorio = aplicativo.Processo.StartInfo.FileName;
                Apps.Add(aplicativo);
                cmbSelecionarProcess.Items.Add(aplicativo.Nome + " | " + Apps.Count);
            }          
        }
        void AbrirApp()/* Cria uma nova Thread de monitoramento de um App*/
        {       
            Apps[AppAtual].Processo.Start();
            Thread thread = new Thread(MonitorarThread);
            thread.Start();         
        }
        static void EnviarEmail(EmailStatus e, string msg, string assunto)
        {
            foreach (var mail in e.Lista)
            {
                try
                {
                    OutlookDotComMail s = new OutlookDotComMail();
                    s.SendMail(new List<string> { mail }, assunto, msg + "\nServer: " + ServerName);
                }
                catch (Exception ex) { Registra("(Falha no Envio de Email) - " + ex.Message +" - Email: '"+mail+"'"); }
            }
        }       
        static void Registra(string log)/* Registro no arquivo*/
        {
            try
            {
                var DataCriacao = DateTime.Now.Date.ToString().Split(' ')[0].Replace("/", "-");
                StreamWriter writer = new StreamWriter("Logs/ObserverLog_" + DataCriacao + ".txt", true);
                writer.WriteLine(MontaMsg(log));
                writer.Close();
            }
            catch (Exception ex) { Mensagem("Erro ao Registrar Log:"+ex.Message); }
        }
        static string MontaMsg(string msg)/* Padroniza a mensagem */
        {
            var Hora = DateTime.Now.Hour.ToString().PadLeft(2, '0')
                + ":"
                + DateTime.Now.Minute.ToString().PadLeft(2, '0')
                + ":"
                + DateTime.Now.Second.ToString().PadLeft(2, '0');

            var Dia = DateTime.Now.Day.ToString().PadLeft(2, '0')
                + "/"
                + DateTime.Now.Month.ToString().PadLeft(2, '0')
                + "/"
                + DateTime.Now.Year.ToString();

            return "[Log (" + Dia + " " + Hora +") Msg:"+ msg +"]\n";
        }          
        void Salvar()
        {                    
            StreamWriter writer = new StreamWriter("Config.JSON", false);
            writer.WriteLine(JsonConvert.SerializeObject(ArqConfig, Formatting.Indented));
            writer.Close();
            File.WriteAllText("ServerName.txt", txtServer.Text);
        }
        void AdicionaPrograma(string c)/* Abre uma janela para Add um App na lista Apps*/
        {
            try
            {
                Adicionar TelaAdicionar = new Adicionar(c);
                if (Apps == null || Apps.Count == 0)
                {
                    Apps = new List<Aplicativo>();
                    AppAtual = -1;
                }

                TelaAdicionar.ShowDialog();
                var App = TelaAdicionar.aplicativo;

                if (App != null)/* Add um App na lista Apps, e no ComboBox*/
                {
                    Apps.Add(App);
                    cmbSelecionarProcess.Items.Add(Apps[Apps.Count - 1].Nome
                        + " | "
                        + (Apps.Count - 1));
                    ConfigAdd();
                }
            }
            catch (Exception) { Mensagem("Erro ao Adicionar App!"); }
        }
        static void Mensagem(string msg)
        {
            MessageBox.Show(
                msg,
                "Observer - Mensagem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
        }         
        void Start()
        {
            Atividade = true;
            if (Apps != null)
            {
                for (int i = 0; i < Apps.Count; i++)
                {
                    AppAtual = i;
                    AbrirApp();
                    Thread.Sleep(Time_WaitOpen);
                }                            
            }
        }
        static void MonitorarThread()
        {
            int ID = AppAtual;
            var app = Apps[ID];

            Inicio:

            try
            {
                if (app.Processo.Responding)
                {
                    var str = "Status Processo(" + app.Nome + "): Em execução";

                    Registra(str);
                }

                /* Contadores de intervalo */
                Stopwatch swReOpen = new Stopwatch();
                swReOpen.Start();

                while (Apps[ID].Ativo)/*Verifica se a Thread foi cancelada pelo usuario */
                {
                    try
                    {
                        if (!app.Processo.Responding)/* Verifica se a aplicação esta respondendo*/
                        {
                            Registra("Status Processo(" + app.Nome + "): Não Respondendo.");

                            if (app.CaseCrashApp.Ativo)/* Verifica se foi setado a opção de reabrir em caso de fechamento*/
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    Registra("ATENÇÃO! Tentando reabrir(" + app.Nome + "): Fechando e Reabrindo a Aplicação.");
                                    
                                    try
                                    {
                                        try { app.Processo.Kill(); } catch { } /* Tentar Matar o processo e aguarda alguns UmSegundos */

                                        Thread.Sleep(UmSegundo * 3);

                                        app.Processo.Start(); /* Inicia o processo e aguarda alguns UmSegundos */

                                        Thread.Sleep(UmSegundo * 3); 

                                        if (app.Processo.Responding) /* Testa Novamente */
                                        {
                                            Registra("ATENÇÃO! Tentando reabrir(" + app.Nome + "): App Reaberto Com Sucesso - Tentativa(" + (i + 1) + " de 3)");
                                            i = 3;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Registra("ATENÇÃO! Tentando reabrir(" + app.Nome + "): Tentativa(" + (i + 1) + " de 3) Erro:" + e.Message);
                                    }
                                }
                                if (!app.Processo.Responding && Apps[ID].Ativo)
                                {
                                    if (app.Email.Ativo) EnviarEmail(app.Email, "ATENÇÃO! Tentando reabrir(" + app.Nome + "): Tentativas sem sucesso", "Observer - Erro Em Processo:" + app.Nome);
                                }
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        var msg = "Status Processo(" + app.Nome + "): Erro ao verificar status. Erro:" + a.Message;
                        Registra(msg);
                        if(app.Email.Ativo) EnviarEmail(app.Email, msg, "Observer - Erro Em Processo:" + app.Nome);
                    }

                    if (app.ReOpen.Ativo)/* Verifica se aplicação esta setada para fechar e abrir de forma programada*/
                    {
                        if (swReOpen.Elapsed > app.ReOpen.Intervalo)
                        {
                            swReOpen = new Stopwatch();
                            swReOpen.Start();
                            try
                            {
                                Registra("Ação Programada(" + app.Nome + "): Fechando e Reabrindo a Aplicação.");
                                app.Processo.Kill();

                                Thread.Sleep(UmSegundo * 5); /*Time Default 'teste'*/

                                var delay = new Stopwatch();
                                delay.Start();
                                do { } while (delay.Elapsed < app.ReOpen.Delay);
                                app.Processo.Start();
                            }
                            catch (Exception e)
                            {
                                var msg = "ATENÇÃO! Tentando reabrir(" + app.Nome + "): Erro ao Realizar operação:" + e.Message;
                                Registra(msg);
                                if (app.Email.Ativo) EnviarEmail(app.Email, msg, "Observer - Erro Em Processo:" + app.Nome);
                            }

                        }
                    }
                    Thread.Sleep(Time_Sleep);
                }
                var Msg="Status Processo(" + app.Nome + "):Cancelado pelo Usuário.";/* Momento de saida da Thread*/
                Registra(Msg);             
                if (app.Email.Ativo) EnviarEmail(app.Email, Msg, "Observer - Status:" + app.Nome);
            }
            catch (Exception ex) 
            { 
                var msg = "Status Processo(" + app.Nome + "):Erro Grave:" + ex.Message+" - Será feita uma tentativa de restarte do processo";
                Registra(msg);
                if (app.Email.Ativo) EnviarEmail(app.Email, msg, "Observer - Erro Em Processo:" + app.Nome);
                app.Processo.Start(); 
                goto Inicio; 
            }
        }

        #endregion     
    }
}
