namespace Visual___Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBunidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbCM_CheckedChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tBunidad.Text, out n))
            {
                tBResultado.Text = Math.Round((double.Parse(tBunidad.Text) / 0.39), 2).ToString();
            }
            else
            {
                tBResultado.Text = "Formato no válido";
            }
            
        }

        private void rbPulgadas_CheckedChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tBunidad.Text, out n))
            {
                tBResultado.Text = Math.Round((double.Parse(tBunidad.Text) * 0.39), 2).ToString();
            }
            else
            {
                tBResultado.Text = "Formato no válido";
            }
        }

        private void rbPie_CheckedChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tBunidad.Text, out n))
            {
                tBResultado.Text = Math.Round((double.Parse(tBunidad.Text) * 0.39 / 12), 2).ToString();
            }
            else
            {
                tBResultado.Text = "Formato no válido";
            }
        }
    }
}