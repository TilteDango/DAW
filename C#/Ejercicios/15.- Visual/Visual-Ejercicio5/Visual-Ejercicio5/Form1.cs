namespace Visual_Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool semaforo = true;

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (semaforo)
            {
                semaforo = false;
                if (double.TryParse(textBox2.Text, out n))
                {
                    textBox1.Text = Math.Round((n * 2.54), 5).ToString();
                }
                else
                {
                    if (textBox2.Text != "")
                    {
                        textBox1.Text = "Formato no válido";
                    }
                    else
                    {
                        textBox1.Text = "0";
                    }
                    
                }
                
               
                semaforo = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (semaforo)
            {
                semaforo = false;
                if (double.TryParse(textBox1.Text, out n))
                {
                    textBox2.Text = Math.Round((n / 2.54), 5).ToString();
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        textBox2.Text = "Formato no válido";
                    }
                    else
                    {
                        textBox2.Text = "0";
                    }
                    
                }
                
                
                semaforo=true;
                
            }
        }
    }
}