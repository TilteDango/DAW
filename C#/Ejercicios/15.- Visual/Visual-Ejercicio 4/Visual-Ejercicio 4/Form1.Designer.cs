namespace Visual_Ejercicio_4
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
            this.lmayor = new System.Windows.Forms.Button();
            this.lmenor = new System.Windows.Forms.Button();
            this.lcorrecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltexto = new System.Windows.Forms.Label();
            this.lnumero = new System.Windows.Forms.Label();
            this.breintentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lmayor
            // 
            this.lmayor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lmayor.Location = new System.Drawing.Point(83, 321);
            this.lmayor.Name = "lmayor";
            this.lmayor.Size = new System.Drawing.Size(120, 63);
            this.lmayor.TabIndex = 0;
            this.lmayor.Text = "Mayor";
            this.lmayor.UseVisualStyleBackColor = true;
            this.lmayor.Click += new System.EventHandler(this.lmayor_Click);
            // 
            // lmenor
            // 
            this.lmenor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lmenor.Location = new System.Drawing.Point(310, 321);
            this.lmenor.Name = "lmenor";
            this.lmenor.Size = new System.Drawing.Size(136, 63);
            this.lmenor.TabIndex = 0;
            this.lmenor.Text = "Menor";
            this.lmenor.UseVisualStyleBackColor = true;
            this.lmenor.Click += new System.EventHandler(this.lmenor_Click);
            // 
            // lcorrecto
            // 
            this.lcorrecto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lcorrecto.Location = new System.Drawing.Point(557, 321);
            this.lcorrecto.Name = "lcorrecto";
            this.lcorrecto.Size = new System.Drawing.Size(120, 63);
            this.lcorrecto.TabIndex = 0;
            this.lcorrecto.Text = "Correcto";
            this.lcorrecto.UseVisualStyleBackColor = true;
            this.lcorrecto.Click += new System.EventHandler(this.lcorrecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adivinador";
            // 
            // ltexto
            // 
            this.ltexto.AutoSize = true;
            this.ltexto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltexto.Location = new System.Drawing.Point(83, 155);
            this.ltexto.Name = "ltexto";
            this.ltexto.Size = new System.Drawing.Size(309, 28);
            this.ltexto.TabIndex = 2;
            this.ltexto.Text = "El numero que estas pensando es: ";
            // 
            // lnumero
            // 
            this.lnumero.AutoSize = true;
            this.lnumero.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnumero.Location = new System.Drawing.Point(398, 161);
            this.lnumero.Name = "lnumero";
            this.lnumero.Size = new System.Drawing.Size(0, 23);
            this.lnumero.TabIndex = 3;
            // 
            // breintentar
            // 
            this.breintentar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breintentar.Location = new System.Drawing.Point(259, 226);
            this.breintentar.Name = "breintentar";
            this.breintentar.Size = new System.Drawing.Size(262, 63);
            this.breintentar.TabIndex = 0;
            this.breintentar.Text = "Volver a jugar";
            this.breintentar.UseVisualStyleBackColor = true;
            this.breintentar.Click += new System.EventHandler(this.breintentar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnumero);
            this.Controls.Add(this.ltexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lcorrecto);
            this.Controls.Add(this.breintentar);
            this.Controls.Add(this.lmenor);
            this.Controls.Add(this.lmayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button lmayor;
        private Button lmenor;
        private Button lcorrecto;
        private Label label1;
        private Label ltexto;
        private Label lnumero;
        private Button breintentar;
    }
}