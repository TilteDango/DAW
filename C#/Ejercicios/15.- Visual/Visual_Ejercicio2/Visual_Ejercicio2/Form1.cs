namespace Visual_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("bloc.txt");
            sw.Write(textBox1.Text);

            sw.Close();
        }

        private void BCargar_Click(object sender, EventArgs e)
        {
            if (File.Exists("bloc.txt"))
            {
                StreamReader sr = new StreamReader("bloc.txt");
                textBox1.Text = sr.ReadToEnd();

                sr.Close();
            }
            else
            {
                MessageBox.Show("El fichero no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}