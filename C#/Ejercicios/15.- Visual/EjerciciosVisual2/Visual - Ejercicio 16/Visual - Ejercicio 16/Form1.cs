namespace Visual___Ejercicio_16
{
    public partial class Form1 : Form
    {
        bool modificar = false;
        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
         
        }


        private void bNuevo_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { tNombre, tPelo, tRaza, tPeso, tTamaño, tOjos };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
                textBoxes[i].Text = "";
            }

            
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            TextBox[] textBoxes = { tNombre, tPelo, tRaza, tPeso, tTamaño, tOjos };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = listView1.SelectedItems[0].SubItems[i].Text;
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < listView1.SelectedIndices.Count; i++)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
            }
            
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                for (int i = 0; i < listView1.SelectedIndices.Count; i++)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
                }
            }


            TextBox[] textBoxes = { tNombre, tPelo, tRaza, tPeso, tTamaño, tOjos };
            bool fallo = false;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text == "")
                {
                    textBoxes[i].BackColor = Color.Red;
                    fallo = true;
                }
            }


            if (!fallo)
            {
                string[] datos = { tNombre.Text, tPelo.Text, tRaza.Text, tPeso.Text, tTamaño.Text, tOjos.Text };
                ListViewItem lvi = new ListViewItem(datos);
                listView1.Items.Add(lvi);
                SaveToFile();
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                bBorrar.Enabled = true;
                bModificar.Enabled = true;
            }
            else
            {
                bBorrar.Enabled=false;
                bModificar.Enabled=false;
            }
            
        }

        private void SaveToFile()
        {
            StreamWriter sw = new StreamWriter("Prueba.csv");

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    sw.Write(listView1.Items[i].SubItems[k].Text + ";");
                }
                sw.WriteLine();
            }

          
            sw.Close();
        }

        private void LoadFromFile()
        {
            string[] columnas;
            if (File.Exists("Prueba.csv"))
            {
                StreamReader sr = new StreamReader("Prueba.csv");
                while (!sr.EndOfStream)
                {
                    columnas = sr.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                    ListViewItem lvi = new ListViewItem(columnas);
                    listView1.Items.Add(lvi);
                   
                }
                sr.Close();
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
    }
}