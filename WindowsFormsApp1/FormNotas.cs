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
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormNotas_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            decimal [] notas = {nota1, nota2, nota3, nota4};

            decimal max = notas.Max();
            decimal promedio = notas.Average();

            MessageBox.Show("La mayor nota de las ingresadas es: " + max.ToString() + "\nEl promedio de las notas ingresadas es: " + promedio.ToString());

            if (promedio >= 9)
            {
                MessageBox.Show("Excelente");

            }else if (promedio < 9 && promedio >= 7)
            {
                MessageBox.Show("Muy Bien");

            }else if( promedio < 7 && promedio >= 4)
            {
                MessageBox.Show("Regular");
            }else
            {
                MessageBox.Show("En proceso de aprendizaje");
            }
        }
    }
}
