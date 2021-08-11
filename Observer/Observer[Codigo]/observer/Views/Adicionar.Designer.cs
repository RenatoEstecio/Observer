namespace observer
{
    partial class Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReabrir = new System.Windows.Forms.TextBox();
            this.cbReOpen = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbMail = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtListaEmail = new System.Windows.Forms.TextBox();
            this.cbCrash = new System.Windows.Forms.CheckBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.lbErro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(16, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(464, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Processo (Opcional):";
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLog.Location = new System.Drawing.Point(39, 621);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(167, 28);
            this.cbLog.TabIndex = 6;
            this.cbLog.Text = "Relatório de Log";
            this.cbLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intervalo: (hh:mm:ss)";
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorio.Location = new System.Drawing.Point(57, 695);
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(180, 29);
            this.txtRelatorio.TabIndex = 7;
            this.txtRelatorio.Text = "00:00:10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Intervalo: (hh:mm:ss)";
            // 
            // txtReabrir
            // 
            this.txtReabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReabrir.Location = new System.Drawing.Point(39, 195);
            this.txtReabrir.Name = "txtReabrir";
            this.txtReabrir.Size = new System.Drawing.Size(180, 29);
            this.txtReabrir.TabIndex = 10;
            this.txtReabrir.Text = "00:00:20";
            // 
            // cbReOpen
            // 
            this.cbReOpen.AutoSize = true;
            this.cbReOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReOpen.Location = new System.Drawing.Point(16, 108);
            this.cbReOpen.Name = "cbReOpen";
            this.cbReOpen.Size = new System.Drawing.Size(171, 28);
            this.cbReOpen.TabIndex = 9;
            this.cbReOpen.Text = "Fechar e Reabrir";
            this.cbReOpen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Intervalo: (hh:mm:ss)";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(279, 726);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 29);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "01:00:00";
            // 
            // cbMail
            // 
            this.cbMail.AutoSize = true;
            this.cbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMail.Location = new System.Drawing.Point(259, 641);
            this.cbMail.Name = "cbMail";
            this.cbMail.Size = new System.Drawing.Size(173, 28);
            this.cbMail.TabIndex = 12;
            this.cbMail.Text = "Email com Status";
            this.cbMail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lista de Emails (Separados por ponto e vírgula)";
            // 
            // txtListaEmail
            // 
            this.txtListaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaEmail.Location = new System.Drawing.Point(16, 364);
            this.txtListaEmail.Multiline = true;
            this.txtListaEmail.Name = "txtListaEmail";
            this.txtListaEmail.Size = new System.Drawing.Size(455, 106);
            this.txtListaEmail.TabIndex = 15;
            // 
            // cbCrash
            // 
            this.cbCrash.AutoSize = true;
            this.cbCrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrash.Location = new System.Drawing.Point(16, 254);
            this.cbCrash.Name = "cbCrash";
            this.cbCrash.Size = new System.Drawing.Size(201, 28);
            this.cbCrash.TabIndex = 17;
            this.cbCrash.Text = "Reabrir Após \'Crash\'";
            this.cbCrash.UseVisualStyleBackColor = true;
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(370, 476);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(98, 27);
            this.bttAdd.TabIndex = 18;
            this.bttAdd.Text = "Adicionar";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(32, 476);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(0, 24);
            this.lbErro.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Delay de Reabertura";
            // 
            // txtDelay
            // 
            this.txtDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelay.Location = new System.Drawing.Point(259, 195);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(180, 29);
            this.txtDelay.TabIndex = 20;
            this.txtDelay.Text = "00:00:00";
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(501, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.cbCrash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtListaEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReabrir);
            this.Controls.Add(this.cbReOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.cbLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReabrir;
        private System.Windows.Forms.CheckBox cbReOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox cbMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtListaEmail;
        private System.Windows.Forms.CheckBox cbCrash;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelay;
    }
}