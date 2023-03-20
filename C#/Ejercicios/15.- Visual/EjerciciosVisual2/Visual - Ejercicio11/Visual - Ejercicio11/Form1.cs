namespace Visual___Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random(); 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBdados.Items.Clear();

            int dados = (int)nUDdados.Value;
            int caras = (int)nUDcaras.Value;
            int n, suma = 0;

            for (int i = 0; i < dados; i++)
            {
                n = r.Next(1, caras + 1);
                lBdados.Items.Add(n);
                suma += n;
            }

            lSuma.Text = suma.ToString();
        }
    }
}