namespace Visual___Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            if (File.Exists(tbFichero.Text))
            {
                StreamReader sr = new StreamReader(tbFichero.Text);
                string[] columnas = sr.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < columnas.Length; i++)
                {
                    listView1.Columns.Add(columnas[i]);
                }

                while (!sr.EndOfStream)
                {
                    columnas = sr.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
               
                    ListViewItem lvi = new ListViewItem(columnas);
                    listView1.Items.Add(lvi);
                       
                    
                }
            }
            else
            {
                tbFichero.Text = "Fichero no encontrado";
            }
            
            
        }
    }
}