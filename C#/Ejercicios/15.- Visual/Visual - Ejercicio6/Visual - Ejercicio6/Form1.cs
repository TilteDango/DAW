namespace Visual___Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> espanol = new List<string>();
        List<string> ingles = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < espanol.Count; i++)
            {
                if (textBox1.Text == espanol[i])
                {
                    textBox2.Text = ingles[i];
                }
                else
                {
                    cont++; 
                }
            }

            if (cont == espanol.Count)
            {
                textBox2.Text = "No encontrado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < espanol.Count; i++)
            {
                if (textBox2.Text == ingles[i])
                {
                    textBox1.Text = espanol[i];
                }
                else
                {
                    cont++;
                }
            }
            
            if (cont == espanol.Count)
            {
                textBox1.Text = "No encontrado";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Prueba.txt");
            


            while (!sr.EndOfStream)
            {
                string[] aux = sr.ReadLine().Split(", ");

                espanol.Add(aux[0]);
                ingles.Add(aux[1]);     
            }
        }
    }
}