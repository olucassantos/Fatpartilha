﻿namespace ChatCliente
{
    partial class frmCliente
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
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Files = new System.Windows.Forms.ListView();
            this.lblfiles = new System.Windows.Forms.Label();
            this.lblusers = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.Location = new System.Drawing.Point(90, 23);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(270, 20);
            this.txtServidorIP.TabIndex = 0;
            this.txtServidorIP.Text = "127.0.0.1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(90, 57);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Lucas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(21, 92);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(340, 327);
            this.txtLog.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(286, 56);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(21, 430);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(238, 20);
            this.txtMensagem.TabIndex = 6;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(265, 428);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(95, 23);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(368, 125);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(267, 142);
            this.Files.TabIndex = 8;
            this.Files.UseCompatibleStateImageBehavior = false;
            // 
            // lblfiles
            // 
            this.lblfiles.AutoSize = true;
            this.lblfiles.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiles.Location = new System.Drawing.Point(410, 92);
            this.lblfiles.Name = "lblfiles";
            this.lblfiles.Size = new System.Drawing.Size(196, 26);
            this.lblfiles.TabIndex = 9;
            this.lblfiles.Text = "Arquivos disponiveis";
            this.lblfiles.Click += new System.EventHandler(this.lblfiles_Click);
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusers.Location = new System.Drawing.Point(410, 279);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(194, 26);
            this.lblusers.TabIndex = 11;
            this.lblusers.Text = "Usuários disponiveis";
            // 
            // usersList
            // 
            this.usersList.Location = new System.Drawing.Point(368, 308);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(267, 142);
            this.usersList.TabIndex = 10;
            this.usersList.UseCompatibleStateImageBehavior = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.lblfiles);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidorIP);
            this.Name = "frmCliente";
            this.Text = "Chat - Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListView Files;
        private System.Windows.Forms.Label lblfiles;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.ListView usersList;
    }
}

