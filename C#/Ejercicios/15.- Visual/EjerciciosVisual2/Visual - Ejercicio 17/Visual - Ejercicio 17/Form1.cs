namespace Visual___Ejercicio_17
{
    public partial class Form1 : Form
    {
        bool modified = false;
        string nombrearchivo = "SinTitulo";
        public Form1(string[] args)
        {
            InitializeComponent();
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    this.Text = Path.GetFileName(args[0]) + ": Bloc de notas";
                    textBox1.Text = File.ReadAllText(args[0]);
                }             
            }
            else
            {
                this.Text = "SinTitulo: Bloc de notas";
            }
            
        }
        

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
            modified = true;
            CountFilesColumns();
                 


        }

        private void CountFilesColumns()
        {
            int linea = 1, columna = 1;
            for (int i = 0; i < textBox1.SelectionStart; i++)
            {
                if (textBox1.Text[i] == '\r' && textBox1.Text[i+1] == '\n')
                {
                    linea++;
                    columna = 0;
                }
                else
                {
                    columna++;
                }
            }

            toolStripStatusLabel1.Text = "Líneas " + linea + " |Columnas: " + columna;
        }

        private void SaveFile()
        {
            if (nombrearchivo == "SinTitulo")
            {
                DialogResult dr2 = saveFileDialog1.ShowDialog();
                nombrearchivo = saveFileDialog1.FileName;

                if (dr2 == DialogResult.OK)
                {
                    File.WriteAllText(nombrearchivo, textBox1.Text);
                    modified = false;
                }

            }
            else
            {
                File.WriteAllText(nombrearchivo, textBox1.Text);
            }
            this.Text = Path.GetFileName(nombrearchivo) + ": Bloc de notas";
        }

        private void SaveFileAs()
        {
            DialogResult dr2 = saveFileDialog1.ShowDialog();
            nombrearchivo = saveFileDialog1.FileName;

            if (dr2 == DialogResult.OK)
            {
                File.WriteAllText(nombrearchivo, textBox1.Text);
                modified = false;
            }
            this.Text = Path.GetFileName(nombrearchivo) + ": Bloc de notas";
        }
        private bool MessageChange()
        {
            DialogResult dr = MessageBox.Show("¿Quieres guardar los cambios de " + nombrearchivo + "?", "Guardar cambios", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes)
            {
                if (nombrearchivo == "SinTitulo")
                {
                    DialogResult dr2 = saveFileDialog1.ShowDialog();
                    nombrearchivo = saveFileDialog1.FileName;

                    if (dr2 == DialogResult.OK)
                    {
                        File.WriteAllText(nombrearchivo, textBox1.Text);
                    }
                   
                }
                else
                {
                    StreamWriter sw = new StreamWriter(nombrearchivo);
                    sw.WriteLine(textBox1.Text);
                }
            }
            else
            {
                if (dr == DialogResult.No)
                {
                    textBox1.Text = "";
                    nombrearchivo = "SinTitulo";
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private bool OpenFile()
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                nombrearchivo = openFileDialog1.FileName;

               
                
                    textBox1.Text = File.ReadAllText(nombrearchivo);
                this.Text = Path.GetFileName(nombrearchivo) + ": Bloc de notas";
                return true;
            }           
            else
            {
                this.Text = Path.GetFileName(nombrearchivo) + ": Bloc de notas";
                return false;
            }
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                MessageChange();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                
                if (!MessageChange()) {
                    OpenFile();
                }
            }
            else
            {
                OpenFile();
            }
            modified = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modified)
            {
                if (MessageChange())
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += DateTime.Now.ToString();
        }

        private void ajusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.WordWrap)
            {
                textBox1.WordWrap = false;
                ajusteDeLineaToolStripMenuItem.Checked = false;
            }
            else
            {
                textBox1.WordWrap = true;
                ajusteDeLineaToolStripMenuItem.Checked = true;
            }
          
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeEstadoToolStripMenuItem.Checked)
            {
                barraDeEstadoToolStripMenuItem.Checked = false;
                statusStrip1.Hide();
            }
            else
            {
                statusStrip1.Show();
                barraDeEstadoToolStripMenuItem.Checked = true;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CountFilesColumns();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            CountFilesColumns();
        }
    }
}