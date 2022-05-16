using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         }


        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string user, pass;
            pass = txtBoxcontraseña.Text;
            user = txtbox1.Text;
            if (user == "equipo3" && pass == "1234")
            {
                MessageBox.Show("Bienvenido");
                Form form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                txtbox1.Text = "";
                txtBoxcontraseña.Text = "";
            }
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
