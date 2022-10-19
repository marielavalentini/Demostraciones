using Microsoft.VisualBasic;
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
    public partial class FormLoops : Form
    {
        public FormLoops()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int total = 0;

            MessageBox.Show("Ingrese numeros menores a 100");

            for (int i = 1; i<= 2; i ++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese numeros: ", "Carga de numeros"));

                while (numero >= 100)
                {
                    MessageBox.Show("Debe ingresar numeros menores a 100, intentelo nuevamente");
                    numero = Convert.ToInt32(Interaction.InputBox("Ingrese numeros: ", "Carga de numeros"));
                }

                total = total + numero; 
            }

            MessageBox.Show("Total: " + total.ToString());
        }
    }
}
