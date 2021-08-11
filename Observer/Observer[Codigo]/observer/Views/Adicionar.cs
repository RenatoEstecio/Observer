using observer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer
{
    public partial class Adicionar : Form
    {
        #region Globais
        string Nome = string.Empty;
        public Aplicativo aplicativo = null;
        #endregion

        #region Eventos
        public Adicionar(string name)
        {
            InitializeComponent();
            Nome = name;           
        }
       
        private void Adicionar_Load(object sender, EventArgs e) {Default(); }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            try { Adiciona(); Close(); } catch (Exception) { lbErro.Text = "Verifique os campos novamente"; }
        }
        #endregion

        #region Métodos

        void Default()
        {
            try
            {
                var aux = Nome.Replace(@"\", "#");
                var vet = aux.Split('#');
                txtNome.Text = vet[vet.Length - 1];
            }
            catch (Exception) { txtNome.Text = Nome; }
            cbCrash.Checked = true;
            cbLog.Checked = true;
            cbReOpen.Checked = true;
            cbMail.Checked = true;
            try
            {
                txtListaEmail.Text = File.ReadAllText("Emails.txt");
            }
            catch (Exception) { }
        }
        void Adiciona()
        {
            /*Define Insatancia e nome do APP*/
            Process nvProcess = new Process();
            nvProcess.StartInfo.FileName = Nome;

            /*Define Intervalo de Logs*/
            Relatorio rel = new Relatorio();
            rel.Ativo = cbLog.Checked;

            if (rel.Ativo == true)
            {
                string[] Intervalo = txtRelatorio.Text.Split(':');
                rel.Intervalo = new TimeSpan(int.Parse(Intervalo[0]), int.Parse(Intervalo[1]), int.Parse(Intervalo[2]));
            }

            /*Define Insatancia e nome do APP*/
            ReabrirCrash rcrash = new ReabrirCrash();
            rcrash.Ativo = cbCrash.Checked;

            /*Define Intervalo de Fechamento e ReAbertura*/
            Reabrir ropen = new Reabrir();
            ropen.Ativo = cbReOpen.Checked;

            if (ropen.Ativo == true)
            {
                string[] Intervalo = txtReabrir.Text.Split(':');
                ropen.Intervalo = new TimeSpan(int.Parse(Intervalo[0]), int.Parse(Intervalo[1]), int.Parse(Intervalo[2]));

                Intervalo = txtDelay.Text.Split(':');
                ropen.Delay = new TimeSpan(int.Parse(Intervalo[0]), int.Parse(Intervalo[1]), int.Parse(Intervalo[2]));
            }

            /*Define Envios de Email*/
            EmailStatus email = new EmailStatus();
            email.Ativo = cbMail.Checked;

            if (email.Ativo == true)
            {
                if (txtListaEmail.Text.Length < 1)
                    throw new ArgumentException("Parameter cannot be null", "ListMail");
                string[] Intervalo = txtEmail.Text.Split(':');
                email.Intervalo = new TimeSpan(int.Parse(Intervalo[0]), int.Parse(Intervalo[1]), int.Parse(Intervalo[2]));
                email.Lista = txtListaEmail.Text.Split(';').ToList();
            }
            aplicativo = new Aplicativo();
            aplicativo.Nome = txtNome.Text.Length == 0 ? Nome: txtNome.Text;
            aplicativo.Processo = nvProcess;
            aplicativo.Log = rel;
            aplicativo.CaseCrashApp = rcrash;
            aplicativo.ReOpen = ropen;
            aplicativo.Email = email;
            aplicativo.Ativo = true;
            aplicativo.Diretorio = nvProcess.StartInfo.FileName;
        }
        #endregion
    }
}
