namespace Practica_4
{
    partial class Form2
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
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.lbEnviar = new System.Windows.Forms.Label();
            this.lbPagar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tarjetas = new System.Windows.Forms.ComboBox();
            this.Servicios = new System.Windows.Forms.ComboBox();
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.lbServicios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Agendabox = new System.Windows.Forms.ComboBox();
            this.lbNumdeCuenta = new System.Windows.Forms.Label();
            this.lbAgenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(21, 20);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(282, 25);
            this.lbBienvenido.TabIndex = 0;
            this.lbBienvenido.Text = "Bienvenido a tu banca movil";
            // 
            // lbEnviar
            // 
            this.lbEnviar.AutoSize = true;
            this.lbEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnviar.Location = new System.Drawing.Point(98, 102);
            this.lbEnviar.Name = "lbEnviar";
            this.lbEnviar.Size = new System.Drawing.Size(104, 20);
            this.lbEnviar.TabIndex = 1;
            this.lbEnviar.Text = "Enviar Dinero";
            // 
            // lbPagar
            // 
            this.lbPagar.AutoSize = true;
            this.lbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagar.Location = new System.Drawing.Point(459, 102);
            this.lbPagar.Name = "lbPagar";
            this.lbPagar.Size = new System.Drawing.Size(55, 20);
            this.lbPagar.TabIndex = 2;
            this.lbPagar.Text = "Pagar ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Tarjetas);
            this.panel1.Controls.Add(this.Servicios);
            this.panel1.Controls.Add(this.lbTarjeta);
            this.panel1.Controls.Add(this.lbServicios);
            this.panel1.Location = new System.Drawing.Point(338, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 155);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // Tarjetas
            // 
            this.Tarjetas.FormattingEnabled = true;
            this.Tarjetas.Location = new System.Drawing.Point(89, 88);
            this.Tarjetas.Name = "Tarjetas";
            this.Tarjetas.Size = new System.Drawing.Size(121, 21);
            this.Tarjetas.TabIndex = 9;
            // 
            // Servicios
            // 
            this.Servicios.FormattingEnabled = true;
            this.Servicios.Location = new System.Drawing.Point(89, 20);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(121, 21);
            this.Servicios.TabIndex = 7;
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Location = new System.Drawing.Point(15, 91);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lbTarjeta.TabIndex = 8;
            this.lbTarjeta.Text = "Tarjeta";
            // 
            // lbServicios
            // 
            this.lbServicios.AutoSize = true;
            this.lbServicios.Location = new System.Drawing.Point(15, 20);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(50, 13);
            this.lbServicios.TabIndex = 7;
            this.lbServicios.Text = "Servicios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lbCantidad);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Agendabox);
            this.panel2.Controls.Add(this.lbNumdeCuenta);
            this.panel2.Controls.Add(this.lbAgenda);
            this.panel2.Location = new System.Drawing.Point(12, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 155);
            this.panel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(11, 91);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 7;
            this.lbCantidad.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Agendabox
            // 
            this.Agendabox.FormattingEnabled = true;
            this.Agendabox.Location = new System.Drawing.Point(128, 17);
            this.Agendabox.Name = "Agendabox";
            this.Agendabox.Size = new System.Drawing.Size(121, 21);
            this.Agendabox.TabIndex = 6;
            // 
            // lbNumdeCuenta
            // 
            this.lbNumdeCuenta.AutoSize = true;
            this.lbNumdeCuenta.Location = new System.Drawing.Point(11, 53);
            this.lbNumdeCuenta.Name = "lbNumdeCuenta";
            this.lbNumdeCuenta.Size = new System.Drawing.Size(95, 13);
            this.lbNumdeCuenta.TabIndex = 6;
            this.lbNumdeCuenta.Text = "Numero de cuenta";
            // 
            // lbAgenda
            // 
            this.lbAgenda.AutoSize = true;
            this.lbAgenda.Location = new System.Drawing.Point(11, 17);
            this.lbAgenda.Name = "lbAgenda";
            this.lbAgenda.Size = new System.Drawing.Size(44, 13);
            this.lbAgenda.TabIndex = 5;
            this.lbAgenda.Text = "Agenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarjeta: **** **** 1234";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(264, 295);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 35);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 351);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPagar);
            this.Controls.Add(this.lbEnviar);
            this.Controls.Add(this.lbBienvenido);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label lbEnviar;
        private System.Windows.Forms.Label lbPagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Tarjetas;
        private System.Windows.Forms.ComboBox Servicios;
        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.Label lbServicios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Agendabox;
        private System.Windows.Forms.Label lbNumdeCuenta;
        private System.Windows.Forms.Label lbAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button btnEnviar;
    }
}