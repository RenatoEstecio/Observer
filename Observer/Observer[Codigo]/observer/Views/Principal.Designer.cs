namespace observer
{
    partial class Observer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observer));
            this.bttAddprogram = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttAbrir = new System.Windows.Forms.Button();
            this.bttFechaApp = new System.Windows.Forms.Button();
            this.bttCarregar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.cmbSelecionarProcess = new System.Windows.Forms.ComboBox();
            this.ofdCaminhoApp = new System.Windows.Forms.OpenFileDialog();
            this.bttAbrirLog = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttAjuda = new System.Windows.Forms.Button();
            this.bttStartarTodos = new System.Windows.Forms.Button();
            this.bttFinalizarApp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.cbAPI = new System.Windows.Forms.CheckBox();
            this.bttRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttAddprogram
            // 
            this.bttAddprogram.BackColor = System.Drawing.Color.AliceBlue;
            this.bttAddprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddprogram.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttAddprogram.Location = new System.Drawing.Point(26, 136);
            this.bttAddprogram.Name = "bttAddprogram";
            this.bttAddprogram.Size = new System.Drawing.Size(273, 33);
            this.bttAddprogram.TabIndex = 2;
            this.bttAddprogram.Text = "Adicionar Novo App";
            this.bttAddprogram.UseVisualStyleBackColor = false;
            this.bttAddprogram.Click += new System.EventHandler(this.bttAddprogram_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione:";
            // 
            // bttAbrir
            // 
            this.bttAbrir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAbrir.Location = new System.Drawing.Point(183, 586);
            this.bttAbrir.Name = "bttAbrir";
            this.bttAbrir.Size = new System.Drawing.Size(126, 33);
            this.bttAbrir.TabIndex = 5;
            this.bttAbrir.Text = "Abrir";
            this.bttAbrir.UseVisualStyleBackColor = false;
            this.bttAbrir.Click += new System.EventHandler(this.bttAbrir_Click);
            // 
            // bttFechaApp
            // 
            this.bttFechaApp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttFechaApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFechaApp.Location = new System.Drawing.Point(26, 625);
            this.bttFechaApp.Name = "bttFechaApp";
            this.bttFechaApp.Size = new System.Drawing.Size(126, 33);
            this.bttFechaApp.TabIndex = 6;
            this.bttFechaApp.Text = "Desvincular";
            this.bttFechaApp.UseVisualStyleBackColor = false;
            this.bttFechaApp.Click += new System.EventHandler(this.bttFechaApp_Click);
            // 
            // bttCarregar
            // 
            this.bttCarregar.BackColor = System.Drawing.Color.AliceBlue;
            this.bttCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCarregar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttCarregar.Location = new System.Drawing.Point(26, 237);
            this.bttCarregar.Name = "bttCarregar";
            this.bttCarregar.Size = new System.Drawing.Size(273, 35);
            this.bttCarregar.TabIndex = 7;
            this.bttCarregar.Text = "Carregar Configurações";
            this.bttCarregar.UseVisualStyleBackColor = false;
            this.bttCarregar.Click += new System.EventHandler(this.bttCarregar_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttExcluir.Enabled = false;
            this.bttExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExcluir.Location = new System.Drawing.Point(26, 586);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(126, 33);
            this.bttExcluir.TabIndex = 8;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = false;
            this.bttExcluir.Click += new System.EventHandler(this.bttExcluir_Click);
            // 
            // cmbSelecionarProcess
            // 
            this.cmbSelecionarProcess.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmbSelecionarProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecionarProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecionarProcess.FormattingEnabled = true;
            this.cmbSelecionarProcess.Location = new System.Drawing.Point(26, 479);
            this.cmbSelecionarProcess.Name = "cmbSelecionarProcess";
            this.cmbSelecionarProcess.Size = new System.Drawing.Size(273, 32);
            this.cmbSelecionarProcess.TabIndex = 9;
            this.cmbSelecionarProcess.Tag = "Selecione um App";
            this.cmbSelecionarProcess.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionarProcess_SelectedIndexChanged);
            // 
            // bttAbrirLog
            // 
            this.bttAbrirLog.BackColor = System.Drawing.Color.AliceBlue;
            this.bttAbrirLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAbrirLog.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttAbrirLog.Location = new System.Drawing.Point(26, 291);
            this.bttAbrirLog.Name = "bttAbrirLog";
            this.bttAbrirLog.Size = new System.Drawing.Size(273, 35);
            this.bttAbrirLog.TabIndex = 10;
            this.bttAbrirLog.Text = "Visualizar Logs";
            this.bttAbrirLog.UseVisualStyleBackColor = false;
            this.bttAbrirLog.Click += new System.EventHandler(this.bttAbrirLog_Click);
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackColor = System.Drawing.Color.AliceBlue;
            this.bttSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalvar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttSalvar.Location = new System.Drawing.Point(26, 185);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(273, 35);
            this.bttSalvar.TabIndex = 11;
            this.bttSalvar.Text = "Salvar Configurações";
            this.bttSalvar.UseVisualStyleBackColor = false;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Configurações:";
            // 
            // bttAjuda
            // 
            this.bttAjuda.BackColor = System.Drawing.Color.AliceBlue;
            this.bttAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAjuda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttAjuda.Location = new System.Drawing.Point(173, 520);
            this.bttAjuda.Name = "bttAjuda";
            this.bttAjuda.Size = new System.Drawing.Size(126, 33);
            this.bttAjuda.TabIndex = 13;
            this.bttAjuda.Text = "Ajuda";
            this.bttAjuda.UseVisualStyleBackColor = false;
            this.bttAjuda.Click += new System.EventHandler(this.bttAjuda_Click);
            // 
            // bttStartarTodos
            // 
            this.bttStartarTodos.BackColor = System.Drawing.Color.AliceBlue;
            this.bttStartarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttStartarTodos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttStartarTodos.Location = new System.Drawing.Point(26, 342);
            this.bttStartarTodos.Name = "bttStartarTodos";
            this.bttStartarTodos.Size = new System.Drawing.Size(273, 35);
            this.bttStartarTodos.TabIndex = 14;
            this.bttStartarTodos.Text = "Iniciar Todos Apps";
            this.bttStartarTodos.UseVisualStyleBackColor = false;
            this.bttStartarTodos.Click += new System.EventHandler(this.bttStartarTodos_Click);
            // 
            // bttFinalizarApp
            // 
            this.bttFinalizarApp.BackColor = System.Drawing.Color.AliceBlue;
            this.bttFinalizarApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFinalizarApp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttFinalizarApp.Location = new System.Drawing.Point(26, 395);
            this.bttFinalizarApp.Name = "bttFinalizarApp";
            this.bttFinalizarApp.Size = new System.Drawing.Size(273, 35);
            this.bttFinalizarApp.TabIndex = 15;
            this.bttFinalizarApp.Text = "Finalizar Aplicação";
            this.bttFinalizarApp.UseVisualStyleBackColor = false;
            this.bttFinalizarApp.Click += new System.EventHandler(this.bttFinalizarApp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(98, 18);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(201, 29);
            this.txtServer.TabIndex = 17;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // cbAPI
            // 
            this.cbAPI.AutoSize = true;
            this.cbAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAPI.Location = new System.Drawing.Point(26, 61);
            this.cbAPI.Name = "cbAPI";
            this.cbAPI.Size = new System.Drawing.Size(142, 28);
            this.cbAPI.TabIndex = 18;
            this.cbAPI.Text = "Monitorar API";
            this.cbAPI.UseVisualStyleBackColor = true;
            this.cbAPI.CheckedChanged += new System.EventHandler(this.cbAPI_CheckedChanged);
            // 
            // bttRemover
            // 
            this.bttRemover.BackColor = System.Drawing.Color.AliceBlue;
            this.bttRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRemover.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bttRemover.Location = new System.Drawing.Point(26, 520);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Size = new System.Drawing.Size(126, 33);
            this.bttRemover.TabIndex = 19;
            this.bttRemover.Text = "Remover";
            this.bttRemover.UseVisualStyleBackColor = false;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 565);
            this.Controls.Add(this.bttRemover);
            this.Controls.Add(this.cbAPI);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttFinalizarApp);
            this.Controls.Add(this.bttStartarTodos);
            this.Controls.Add(this.bttAjuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.bttAbrirLog);
            this.Controls.Add(this.cmbSelecionarProcess);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttCarregar);
            this.Controls.Add(this.bttFechaApp);
            this.Controls.Add(this.bttAbrir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttAddprogram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Observer";
            this.Text = "Observer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Observer_FormClosing);
            this.Load += new System.EventHandler(this.Observer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttAddprogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttAbrir;
        private System.Windows.Forms.Button bttFechaApp;
        private System.Windows.Forms.Button bttCarregar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.ComboBox cmbSelecionarProcess;
        private System.Windows.Forms.OpenFileDialog ofdCaminhoApp;
        private System.Windows.Forms.Button bttAbrirLog;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Button bttAjuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttStartarTodos;
        private System.Windows.Forms.Button bttFinalizarApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.CheckBox cbAPI;
        private System.Windows.Forms.Button bttRemover;
    }
}

