namespace Visual___Ejercicio_18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Plazas = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 474);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Plazas});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(567, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(221, 184);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Plazas
            // 
            this.Plazas.Text = "Plazas";
            this.Plazas.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduce el nombre para la reserva ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reserva de autobuses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Nombre;
        private ColumnHeader Plazas;
        private Label label1;
    }
}