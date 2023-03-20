using System.Net;

namespace Visual_Ejericicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double n1, n2;

            if (double.TryParse(tBoperador1.Text, out n1) && double.TryParse(tBoperador2.Text, out n2))
            {
                switch (btn.Text)
                {
                    case "+": tBresultado.Text =  (n1 + n2).ToString(); label4.Text = "+"; break;
                    case "-": tBresultado.Text = (n1 - n2).ToString(); label4.Text = "-"; break;
                    case "*": tBresultado.Text = (n1 * n2).ToString(); label4.Text = "*"; break;
                    case "/":
                        if (n2 == 0)
                        {
                            tBresultado.Text = "No dividas por 0";
                        }
                        else
                        {
                            tBresultado.Text = (n1 / n2).ToString(); break;
                        }
                        label4.Text = "/";
                        break;
                        
                    default:
                        break;
                }
            }
            else
            {
                tBresultado.Text = " Formato no correcto";
            }

            
        }
    }
}