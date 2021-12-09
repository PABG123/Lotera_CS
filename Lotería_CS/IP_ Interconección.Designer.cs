
using System;

namespace Lotería_CS
{
    partial class IP_interconección
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
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label_host = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.PUERTO_1 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(437, 30);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(112, 27);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(12, 37);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(40, 13);
            this.label_host.TabIndex = 1;
            this.label_host.Text = "HOST:";
            this.label_host.Click += new System.EventHandler(this.Label_host_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(57, 37);
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(125, 17);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "192.168.42.74";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // PUERTO_1
            // 
            this.PUERTO_1.AutoSize = true;
            this.PUERTO_1.Location = new System.Drawing.Point(203, 37);
            this.PUERTO_1.Name = "PUERTO_1";
            this.PUERTO_1.Size = new System.Drawing.Size(55, 13);
            this.PUERTO_1.TabIndex = 3;
            this.PUERTO_1.Text = "PUERTO:";
            this.PUERTO_1.Click += new System.EventHandler(this.PUERTO_1_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(264, 37);
            this.txtPuerto.Multiline = true;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(132, 17);
            this.txtPuerto.TabIndex = 4;
            this.txtPuerto.Text = "192.168.42.74";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(15, 69);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(679, 251);
            this.txtEstatus.TabIndex = 6;
            // 
            // IP_interconección
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.PUERTO_1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.btnComenzar);
            this.Name = "IP_interconección";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP_Servidor";
            this.Load += new System.EventHandler(this.IP_interconección_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void IP_interconección_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PUERTO_1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label_host_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label PUERTO_1;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}