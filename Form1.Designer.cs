namespace Practica_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbBanco = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxcontraseña = new System.Windows.Forms.TextBox();
            this.lbcontraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(135, 140);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(68, 20);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Usuario:";
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.Location = new System.Drawing.Point(49, 35);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(191, 29);
            this.lbBanco.TabIndex = 1;
            this.lbBanco.Text = "Banco nacional";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(231, 140);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(163, 20);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(275, 214);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBoxcontraseña
            // 
            this.txtBoxcontraseña.Location = new System.Drawing.Point(231, 175);
            this.txtBoxcontraseña.Name = "txtBoxcontraseña";
            this.txtBoxcontraseña.Size = new System.Drawing.Size(163, 20);
            this.txtBoxcontraseña.TabIndex = 4;
            // 
            // lbcontraseña
            // 
            this.lbcontraseña.AutoSize = true;
            this.lbcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontraseña.Location = new System.Drawing.Point(135, 175);
            this.lbcontraseña.Name = "lbcontraseña";
            this.lbcontraseña.Size = new System.Drawing.Size(96, 20);
            this.lbcontraseña.TabIndex = 5;
            this.lbcontraseña.Text = "Contraseña:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 304);
            this.Controls.Add(this.lbcontraseña);
            this.Controls.Add(this.txtBoxcontraseña);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.lbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbBanco;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbcontraseña;
        private System.Windows.Forms.TextBox txtBoxcontraseña;
    }
}

