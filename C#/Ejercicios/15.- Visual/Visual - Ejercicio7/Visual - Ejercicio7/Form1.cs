namespace Visual___Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dt = DateTime.Now;
            WriteDate();

        }

        private void WriteDate()
        {
            textBox3.Text = dt.Day.ToString();
            textBox4.Text = dt.Month.ToString();
            textBox2.Text = dt.Year.ToString();
        }

        private string WriteFile()
        {
            string file = "";

            if (dt.Day < 10)
            {
                file += "0" + dt.Day.ToString();
            }
            else
            {
                file += dt.Day.ToString();
            }

            if (dt.Month < 10)
            {
                file += "0" + dt.Month.ToString();
            }
            else
            {
                file += dt.Month.ToString();
            }

            file += dt.Year.ToString() + ".txt";

            return file;

        }

        DateTime dt = new DateTime();
        bool changed = false;
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFiles();
            dt = dt.AddDays(1);
            WriteDate();
            LoadFiles();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SaveFiles();
            dt = dt.AddDays(-1);
            WriteDate();
            LoadFiles();
        }

        private void LoadFiles()
        {

                if (File.Exists(WriteFile()))
                {
                    StreamReader sr = new StreamReader(WriteFile());
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    textBox1.Text = "";
                    
                }
            changed = false;
        }

        private void SaveFiles()
        {
        

            if (changed)
            {
                StreamWriter sw = new StreamWriter(WriteFile());
                sw.WriteLine(textBox1.Text);
                changed = false;
                sw.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                SaveFiles();
        }
    }
}