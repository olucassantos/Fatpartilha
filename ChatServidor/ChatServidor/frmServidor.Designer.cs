﻿namespace ChatServidor
{
    partial class frmServidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServidor));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.usersList = new System.Windows.Forms.ListView();
            this.UserListSet = new System.Windows.Forms.ImageList(this.components);
            this.txtIP = new System.Windows.Forms.TextBox();
            this.attUsuarios = new System.Windows.Forms.Button();
            this.mstMessage = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.attClientList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 64);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(390, 229);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.attUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço IP : ";
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(279, 27);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(124, 23);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Iniciar Atendimento";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // usersList
            // 
            this.usersList.AllowColumnReorder = true;
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersList.LargeImageList = this.UserListSet;
            this.usersList.Location = new System.Drawing.Point(13, 361);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(390, 145);
            this.usersList.TabIndex = 4;
            this.usersList.UseCompatibleStateImageBehavior = false;
            // 
            // UserListSet
            // 
            this.UserListSet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UserListSet.ImageStream")));
            this.UserListSet.TransparentColor = System.Drawing.Color.Transparent;
            this.UserListSet.Images.SetKeyName(0, "User.png");
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 28);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(179, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // attUsuarios
            // 
            this.attUsuarios.Location = new System.Drawing.Point(279, 332);
            this.attUsuarios.Name = "attUsuarios";
            this.attUsuarios.Size = new System.Drawing.Size(124, 23);
            this.attUsuarios.TabIndex = 5;
            this.attUsuarios.Text = "Atualizar Lista";
            this.attUsuarios.UseVisualStyleBackColor = true;
            this.attUsuarios.Click += new System.EventHandler(this.attUsuarios_Click);
            // 
            // mstMessage
            // 
            this.mstMessage.Location = new System.Drawing.Point(13, 299);
            this.mstMessage.Name = "mstMessage";
            this.mstMessage.Size = new System.Drawing.Size(309, 20);
            this.mstMessage.TabIndex = 6;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(328, 300);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 19);
            this.send.TabIndex = 7;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // attClientList
            // 
            this.attClientList.Location = new System.Drawing.Point(94, 332);
            this.attClientList.Name = "attClientList";
            this.attClientList.Size = new System.Drawing.Size(179, 23);
            this.attClientList.TabIndex = 8;
            this.attClientList.Text = "Atualizar Lista dos Cliente";
            this.attClientList.UseVisualStyleBackColor = true;
            this.attClientList.Click += new System.EventHandler(this.attClientList_Click);
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(418, 518);
            this.Controls.Add(this.attClientList);
            this.Controls.Add(this.send);
            this.Controls.Add(this.mstMessage);
            this.Controls.Add(this.attUsuarios);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Name = "frmServidor";
            this.Text = "Chat Servidor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServirdor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button attUsuarios;
        private System.Windows.Forms.TextBox mstMessage;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ImageList UserListSet;
        private System.Windows.Forms.Button attClientList;
    }
}

