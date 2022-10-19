using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;

            if (nombre == "mariela" && password == "123456" )
            {
                MessageBox.Show("Bienvenida " + nombre.ToUpper());
            }else
            {
                MessageBox.Show("El usuario no esta registrado");
            }
        }
    }
}
