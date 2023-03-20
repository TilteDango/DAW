namespace Visual___Ejercicio9
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
            this.tbEscribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lLetras = new System.Windows.Forms.Label();
            this.lPalabras = new System.Windows.Forms.Label();
            this.lEspacios = new System.Windows.Forms.Label();
            this.lVocales = new System.Windows.Forms.Label();
            this.lConsonantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEscribe
            // 
            this.tbEscribe.Location = new System.Drawing.Point(180, 171);
            this.tbEscribe.Multiline = true;
            this.tbEscribe.Name = "tbEscribe";
            this.tbEscribe.Size = new System.Drawing.Size(608, 82);
            this.tbEscribe.TabIndex = 0;
            this.tbEscribe.TextChanged += new System.EventHandler(this.tbEscribe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta cosas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escribe lo que necesites";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero total de letras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero total de palabras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero total de espacios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero total de vocales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numero total de consonantes";
            // 
            // lLetras
            // 
            this.lLetras.AutoSize = true;
            this.lLetras.Location = new System.Drawing.Point(222, 256);
            this.lLetras.Name = "lLetras";
            this.lLetras.Size = new System.Drawing.Size(13, 15);
            this.lLetras.TabIndex = 3;
            this.lLetras.Text = "0";
            // 
            // lPalabras
            // 
            this.lPalabras.AutoSize = true;
            this.lPalabras.Location = new System.Drawing.Point(222, 293);
            this.lPalabras.Name = "lPalabras";
            this.lPalabras.Size = new System.Drawing.Size(13, 15);
            this.lPalabras.TabIndex = 3;
            this.lPalabras.Text = "0";
            // 
            // lEspacios
            // 
            this.lEspacios.AutoSize = true;
            this.lEspacios.Location = new System.Drawing.Point(222, 330);
            this.lEspacios.Name = "lEspacios";
            this.lEspacios.Size = new System.Drawing.Size(13, 15);
            this.lEspacios.TabIndex = 3;
            this.lEspacios.Text = "0";
            // 
            // lVocales
            // 
            this.lVocales.AutoSize = true;
            this.lVocales.Location = new System.Drawing.Point(222, 370);
            this.lVocales.Name = "lVocales";
            this.lVocales.Size = new System.Drawing.Size(13, 15);
            this.lVocales.TabIndex = 3;
            this.lVocales.Text = "0";
            // 
            // lConsonantes
            // 
            this.lConsonantes.AutoSize = true;
            this.lConsonantes.Location = new System.Drawing.Point(222, 410);
            this.lConsonantes.Name = "lConsonantes";
            this.lConsonantes.Size = new System.Drawing.Size(13, 15);
            this.lConsonantes.TabIndex = 3;
            this.lConsonantes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lConsonantes);
            this.Controls.Add(this.lVocales);
            this.Controls.Add(this.lEspacios);
            this.Controls.Add(this.lPalabras);
            this.Controls.Add(this.lLetras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEscribe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbEscribe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lLetras;
        private Label lPalabras;
        private Label lEspacios;
        private Label lVocales;
        private Label lConsonantes;
    }
}