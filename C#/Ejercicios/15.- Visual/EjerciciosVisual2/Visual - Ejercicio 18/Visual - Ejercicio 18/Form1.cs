namespace Visual___Ejercicio_18
{
    public partial class Form1 : Form
    {
        int n = 1, posx, posy;
        Button[] buttons = new Button[64];
        
        public Form1()
        {
            InitializeComponent();
            MakeButtons();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (textBox1.Text == "" || textBox1.Text == "null")
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error en el TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].BackColor == Color.Orange)
                    {
                        buttons[i].BackColor = Color.Red;
                        buttons[i].Enabled = false;
                        s += buttons[i].Text + ", ";
                    }
                }
                if (s.Length < 2)
                {
                    
                    MessageBox.Show("Los asientos no pueden estar vacío", "Error en el TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    s = s.Substring(0, s.Length - 2);
                    string[] columnas = new string[2];


                    columnas[0] = textBox1.Text;

                    columnas[1] = s;
                    ListViewItem lvi = new ListViewItem(columnas);
                    listView1.Items.Add(lvi);
                    textBox1.Text = "";
                }
                               
            }
                                  
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void MakeButtons()
        {
            for (int i = 0; i < 64; i++)
            {
                Button myButton = new Button();
                myButton.Text = n.ToString();
                n++;
                buttons[i] = myButton;
                myButton.Location = new Point(posy, posx);
                posy += 90;
                if (i % 4 == 1)
                {
                    posy += 90;
                }
                if (i % 4 == 3 && i != 0)
                {
                    posx += 30;
                    posy = 0;
                }
                myButton.BackColor = Color.Green;
               myButton.Click += new EventHandler(Reserve_Click);
                panel1.Controls.Add(myButton);
            }
           
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            Button miBoton = (Button)sender;
            if (miBoton.BackColor == Color.Orange)
            {
                miBoton.BackColor = Color.Green;
            }
            else
            {
                miBoton.BackColor = Color.Orange;
            }
            
            
        }
    }
}