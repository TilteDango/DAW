namespace Visual___Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("prueba.txt"))
            {
                LoadFile();
            }
           
        }

        private void LoadFile()
        {
            StreamReader sr = new StreamReader("prueba.txt");
            while (!sr.EndOfStream)
            {
                lBGuarda.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        private void SaveFile()
        {
            StreamWriter sw = new StreamWriter("prueba.txt");

            for (int i = 0; i < lBGuarda.Items.Count; i++)
            {
                sw.WriteLine(lBGuarda.Items[i]);
            }

            sw.Close();
        }

        private void tBspain_TextChanged(object sender, EventArgs e)
        {
            MuestraEnviar();
        }

        private void MuestraEnviar()
        {
            if (tBspain.Text != "" && tBen.Text != "")
            {
                bEnviar.Enabled = true;
            }
        }

        private void tBen_TextChanged(object sender, EventArgs e)
        {
            MuestraEnviar();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            lBGuarda.Items.Add (tBspain.Text + "          --------->        " + tBen.Text);
            tBen.Text = "";
            tBspain.Text = "";
        }

        private void lBGuarda_SelectedIndexChanged(object sender, EventArgs e)
        {
            bBorrar.Enabled = true;

        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            lBGuarda.Items.RemoveAt(lBGuarda.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
        }
    }
}