namespace Visual___Ejercicio_16
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tPelo = new System.Windows.Forms.TextBox();
            this.tRaza = new System.Windows.Forms.TextBox();
            this.tPeso = new System.Windows.Forms.TextBox();
            this.tTamaño = new System.Windows.Forms.TextBox();
            this.tOjos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color del pelo";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Raza";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Peso";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tamaño";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Color de ojos";
            this.columnHeader6.Width = 130;
            // 
            // tNombre
            // 
            this.tNombre.Enabled = false;
            this.tNombre.Location = new System.Drawing.Point(12, 245);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(112, 23);
            this.tNombre.TabIndex = 1;
            // 
            // tPelo
            // 
            this.tPelo.Enabled = false;
            this.tPelo.Location = new System.Drawing.Point(142, 245);
            this.tPelo.Name = "tPelo";
            this.tPelo.Size = new System.Drawing.Size(112, 23);
            this.tPelo.TabIndex = 2;
            // 
            // tRaza
            // 
            this.tRaza.Enabled = false;
            this.tRaza.Location = new System.Drawing.Point(269, 245);
            this.tRaza.Name = "tRaza";
            this.tRaza.Size = new System.Drawing.Size(112, 23);
            this.tRaza.TabIndex = 3;
            // 
            // tPeso
            // 
            this.tPeso.Enabled = false;
            this.tPeso.Location = new System.Drawing.Point(387, 245);
            this.tPeso.Name = "tPeso";
            this.tPeso.Size = new System.Drawing.Size(112, 23);
            this.tPeso.TabIndex = 4;
            // 
            // tTamaño
            // 
            this.tTamaño.Enabled = false;
            this.tTamaño.Location = new System.Drawing.Point(521, 245);
            this.tTamaño.Name = "tTamaño";
            this.tTamaño.Size = new System.Drawing.Size(112, 23);
            this.tTamaño.TabIndex = 5;
            // 
            // tOjos
            // 
            this.tOjos.Enabled = false;
            this.tOjos.Location = new System.Drawing.Point(648, 245);
            this.tOjos.Name = "tOjos";
            this.tOjos.Size = new System.Drawing.Size(112, 23);
            this.tOjos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color del pelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tamaño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Color de ojos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 60);
            this.label7.TabIndex = 3;
            this.label7.Text = "VisualGatos";
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(410, 359);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 85;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(576, 359);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 81;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Enabled = false;
            this.bBorrar.Location = new System.Drawing.Point(657, 359);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 82;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Enabled = false;
            this.bModificar.Location = new System.Drawing.Point(495, 359);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 80;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tOjos);
            this.Controls.Add(this.tTamaño);
            this.Controls.Add(this.tPeso);
            this.Controls.Add(this.tRaza);
            this.Controls.Add(this.tPelo);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox tNombre;
        private TextBox tPelo;
        private TextBox tRaza;
        private TextBox tPeso;
        private TextBox tTamaño;
        private TextBox tOjos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button bNuevo;
        private Button bGuardar;
        private Button bBorrar;
        private Button bModificar;
    }
}