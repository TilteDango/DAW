namespace Visual___Ejercicio_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadFile();
        }
        Random r = new Random();

        private void LoadFile()
        {
            StreamReader sr = new StreamReader("primero.txt");

            while (!sr.EndOfStream)
            {
                cBprimero.Items.Add(sr.ReadLine());
            }

            sr.Close();

            StreamReader sr2 = new StreamReader("segundo.txt");

            while (!sr2.EndOfStream)
            {
                cBsegundo.Items.Add(sr2.ReadLine());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lResultado.Text = cBprimero.SelectedItem.ToString() + " " + cBsegundo.SelectedItem.ToString();
        }

        private void bAleatoria_Click(object sender, EventArgs e)
        {
            lResultado.Text = cBprimero.Items[r.Next(cBprimero.Items.Count)].ToString() + " " +  cBsegundo.Items[r.Next(cBsegundo.Items.Count)].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lResultado.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }
    }
}