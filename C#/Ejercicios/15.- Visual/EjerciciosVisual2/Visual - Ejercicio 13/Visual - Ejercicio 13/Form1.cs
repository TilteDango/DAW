namespace Visual___Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pPregunta1.Hide();
            pPregunta2.Hide();
            pPregunta3.Hide();
            panel1.Hide();

        }
        int suma = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pPrincipal.Hide();
            pPregunta1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rBbien.Checked)
            {
                suma++;
            }

            pPregunta1.Hide();
            pPregunta2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rBClaseB.Checked)
            {
                suma++;
            }

            pPregunta2.Hide();
            pPregunta3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rBbien2.Checked)
            {
                suma++;
            }

            pPregunta3.Hide();
            panel1.Show();

            label11.Text = suma + " preguntas correctas sobre 3";

        }
    }
}