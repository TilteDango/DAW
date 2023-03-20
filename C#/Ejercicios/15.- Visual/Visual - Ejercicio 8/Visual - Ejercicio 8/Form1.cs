namespace Visual___Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            b = button9;
        }

        Button b = new Button();
      
        private void button1_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = (button1.Location.X + 21);
            int y = button1.Location.Y;
            label1.Location = new Point(x, y);
            button1.Hide();
            b= button1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b.Show(); 
            int x = button8.Location.X + 21;
            int y = button8.Location.Y;
            label1.Location = new Point(x, y);
            button8.Hide();
            b = button8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button2.Location.X + 21 ;
            int y = button2.Location.Y;
            label1.Location = new Point(x, y);
            button2.Hide();
            b = button2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.Show(); 
            int x = button3.Location.X + 21;
            int y = button3.Location.Y;
            label1.Location = new Point(x, y);
            button3.Hide();
            b = button3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button9.Location.X +21;
            int y = button9.Location.Y;
            label1.Location = new Point(x, y);
            button9.Hide();
            b = button9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button4.Location.X + 21;
            int y = button4.Location.Y;
            label1.Location = new Point(x, y);
            button4.Hide();
            b = button4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button7.Location.X + 21;
            int y = button7.Location.Y;
            label1.Location = new Point(x, y);
            button7.Hide();
            b = button7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button6.Location.X +21;
            int y = button6.Location.Y;
            label1.Location = new Point(x, y);
            button6.Hide();
            b = button6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b.Show();
            int x = button5.Location.X + 21;
            int y = button5.Location.Y;
            label1.Location = new Point(x, y);
            button5.Hide();
            b = button5;
        }
    }
}