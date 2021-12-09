
namespace Lotería_CS
{
    partial class Conexión_IP
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
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.PUERTO_1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label_host = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar_ = new System.Windows.Forms.Button();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(275, 38);
            this.txtPuerto.Multiline = true;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(132, 17);
            this.txtPuerto.TabIndex = 9;
            this.txtPuerto.Text = "192.168.42.74";
            // 
            // PUERTO_1
            // 
            this.PUERTO_1.AutoSize = true;
            this.PUERTO_1.Location = new System.Drawing.Point(214, 38);
            this.PUERTO_1.Name = "PUERTO_1";
            this.PUERTO_1.Size = new System.Drawing.Size(55, 13);
            this.PUERTO_1.TabIndex = 8;
            this.PUERTO_1.Text = "PUERTO:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(68, 38);
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(125, 17);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = "192.168.42.74";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(23, 38);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(40, 13);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "HOST:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(448, 31);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(112, 27);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar ✨";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(26, 81);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(600, 118);
            this.txtMensaje.TabIndex = 10;
            // 
            // btnEnviar_
            // 
            this.btnEnviar_.Location = new System.Drawing.Point(514, 205);
            this.btnEnviar_.Name = "btnEnviar_";
            this.btnEnviar_.Size = new System.Drawing.Size(112, 27);
            this.btnEnviar_.TabIndex = 11;
            this.btnEnviar_.Text = "Enviar ";
            this.btnEnviar_.UseVisualStyleBackColor = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(26, 238);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(600, 266);
            this.txtEstatus.TabIndex = 12;
            // 
            // Conexión_IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 570);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.btnEnviar_);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.PUERTO_1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.btnConectar);
            this.Name = "Conexión_IP";
            this.Text = "Conexión_IP";
            this.Load += new System.EventHandler(this.Conexión_IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label PUERTO_1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar_;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}