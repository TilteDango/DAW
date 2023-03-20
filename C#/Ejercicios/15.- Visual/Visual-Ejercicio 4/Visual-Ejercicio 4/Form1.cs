namespace Visual_Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Empezar();
            
        }

        int mayor = 100, menor = 0, cont = 0;
        Random r = new Random();

        private void lmayor_Click(object sender, EventArgs e)
        {
            if (mayor == menor)
            {
                ltexto.Text = "No hay más numeros, el número es: ";
            }
            else
            {
                cont++;
                menor = int.Parse(lnumero.Text) + 1;
                EscribeNumero();
            }
            
        }

        private void lmenor_Click(object sender, EventArgs e)
        {
            if (mayor == menor)
            {
                ltexto.Text = "No hay más numeros, el número es: "; 
            }
            else
            {
                cont++;
                mayor = int.Parse(lnumero.Text);
                EscribeNumero();
            }
            
        }

        private void Empezar()
        {
            ltexto.Text = "El numero que estas pensando es: ";
            cont = 0;
            menor = 0;
            mayor = 100;
            lmayor.Show();
            lmenor.Show();
            lcorrecto.Show();
            breintentar.Hide();
            EscribeNumero();
        }

        private void breintentar_Click(object sender, EventArgs e)
        {
            Empezar();
        }

        private void lcorrecto_Click(object sender, EventArgs e)
        {
            ltexto.Text = "Has necesitado: ";
            lnumero.Text = cont.ToString() + " intentos";
            lmayor.Hide();
            lmenor.Hide();
            lcorrecto.Hide();
            breintentar.Show();
        }

        private void EscribeNumero()
        {
            lnumero.Text = r.Next(menor, mayor).ToString();
        }
    }
}