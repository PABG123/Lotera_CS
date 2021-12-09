
namespace Lotería_CS
{
    partial class Servidor
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
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.btnConectar_ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(319, 51);
            this.txtPuerto.Multiline = true;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(132, 17);
            this.txtPuerto.TabIndex = 9;
            this.txtPuerto.Text = "192.168.42.74";
            // 
            // PUERTO_1
            // 
            this.PUERTO_1.AutoSize = true;
            this.PUERTO_1.Location = new System.Drawing.Point(258, 51);
            this.PUERTO_1.Name = "PUERTO_1";
            this.PUERTO_1.Size = new System.Drawing.Size(55, 13);
            this.PUERTO_1.TabIndex = 8;
            this.PUERTO_1.Text = "PUERTO:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(112, 51);
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(125, 17);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = "192.168.42.74";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(67, 51);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(40, 13);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "HOST:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(492, 44);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(112, 27);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Location = new System.Drawing.Point(51, 77);
            this.txt_Mensaje.Multiline = true;
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(679, 135);
            this.txt_Mensaje.TabIndex = 10;
            // 
            // btnConectar_
            // 
            this.btnConectar_.Location = new System.Drawing.Point(618, 218);
            this.btnConectar_.Name = "btnConectar_";
            this.btnConectar_.Size = new System.Drawing.Size(112, 27);
            this.btnConectar_.TabIndex = 11;
            this.btnConectar_.Text = "Enviar";
            this.btnConectar_.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(679, 311);
            this.textBox1.TabIndex = 12;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConectar_);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.PUERTO_1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.btnConectar);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label PUERTO_1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txt_Mensaje;
        private System.Windows.Forms.Button btnConectar_;
        private System.Windows.Forms.TextBox textBox1;
    }
}