namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);

            if (sueldo > 0)
            {
                MessageBox.Show(nombre.ToUpper() + " Sueldo: " + sueldo.ToString());
            }else
            {
                MessageBox.Show("El sueldo debe ser mayor a cero");
            }
        }
    }
}