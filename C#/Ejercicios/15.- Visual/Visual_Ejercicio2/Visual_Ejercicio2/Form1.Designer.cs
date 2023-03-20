namespace Visual_Ejercicio2
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
            this.BNuevo = new System.Windows.Forms.Button();
            this.BCargar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BNuevo
            // 
            this.BNuevo.Location = new System.Drawing.Point(96, 327);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(98, 27);
            this.BNuevo.TabIndex = 0;
            this.BNuevo.Text = "Nuevo";
            this.BNuevo.UseVisualStyleBackColor = true;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BCargar
            // 
            this.BCargar.Location = new System.Drawing.Point(454, 327);
            this.BCargar.Name = "BCargar";
            this.BCargar.Size = new System.Drawing.Size(113, 27);
            this.BCargar.TabIndex = 0;
            this.BCargar.Text = "Cargar";
            this.BCargar.UseVisualStyleBackColor = true;
            this.BCargar.Click += new System.EventHandler(this.BCargar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(290, 327);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(92, 27);
            this.BGuardar.TabIndex = 0;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 314);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCargar);
            this.Controls.Add(this.BNuevo);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BNuevo;
        private Button BCargar;
        private Button BGuardar;
        private TextBox textBox1;
    }
}