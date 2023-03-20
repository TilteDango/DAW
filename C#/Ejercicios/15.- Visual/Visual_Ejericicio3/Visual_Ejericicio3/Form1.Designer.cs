namespace Visual_Ejericicio3
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
            this.tBoperador1 = new System.Windows.Forms.TextBox();
            this.tBoperador2 = new System.Windows.Forms.TextBox();
            this.tBresultado = new System.Windows.Forms.TextBox();
            this.bTMultiplica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bTDivide = new System.Windows.Forms.Button();
            this.bTResta = new System.Windows.Forms.Button();
            this.bTSuma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoperador1
            // 
            this.tBoperador1.Location = new System.Drawing.Point(120, 100);
            this.tBoperador1.Name = "tBoperador1";
            this.tBoperador1.Size = new System.Drawing.Size(100, 23);
            this.tBoperador1.TabIndex = 0;
            // 
            // tBoperador2
            // 
            this.tBoperador2.Location = new System.Drawing.Point(324, 100);
            this.tBoperador2.Name = "tBoperador2";
            this.tBoperador2.Size = new System.Drawing.Size(100, 23);
            this.tBoperador2.TabIndex = 1;
            // 
            // tBresultado
            // 
            this.tBresultado.Location = new System.Drawing.Point(526, 100);
            this.tBresultado.Name = "tBresultado";
            this.tBresultado.Size = new System.Drawing.Size(145, 23);
            this.tBresultado.TabIndex = 2;
            // 
            // bTMultiplica
            // 
            this.bTMultiplica.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTMultiplica.Location = new System.Drawing.Point(324, 291);
            this.bTMultiplica.Name = "bTMultiplica";
            this.bTMultiplica.Size = new System.Drawing.Size(52, 52);
            this.bTMultiplica.TabIndex = 3;
            this.bTMultiplica.Text = "*";
            this.bTMultiplica.UseVisualStyleBackColor = true;
            this.bTMultiplica.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // bTDivide
            // 
            this.bTDivide.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTDivide.Location = new System.Drawing.Point(416, 291);
            this.bTDivide.Name = "bTDivide";
            this.bTDivide.Size = new System.Drawing.Size(52, 52);
            this.bTDivide.TabIndex = 3;
            this.bTDivide.Text = "/";
            this.bTDivide.UseVisualStyleBackColor = true;
            this.bTDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // bTResta
            // 
            this.bTResta.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTResta.Location = new System.Drawing.Point(416, 210);
            this.bTResta.Name = "bTResta";
            this.bTResta.Size = new System.Drawing.Size(52, 52);
            this.bTResta.TabIndex = 3;
            this.bTResta.Text = "-";
            this.bTResta.UseVisualStyleBackColor = true;
            this.bTResta.Click += new System.EventHandler(this.btn_Click);
            // 
            // bTSuma
            // 
            this.bTSuma.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTSuma.Location = new System.Drawing.Point(324, 210);
            this.bTSuma.Name = "bTSuma";
            this.bTSuma.Size = new System.Drawing.Size(52, 52);
            this.bTSuma.TabIndex = 3;
            this.bTSuma.Text = "+";
            this.bTSuma.UseVisualStyleBackColor = true;
            this.bTSuma.Click += new System.EventHandler(this.btn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 46);
            this.label4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(526, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 46);
            this.label6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(428, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTSuma);
            this.Controls.Add(this.bTResta);
            this.Controls.Add(this.bTDivide);
            this.Controls.Add(this.bTMultiplica);
            this.Controls.Add(this.tBresultado);
            this.Controls.Add(this.tBoperador2);
            this.Controls.Add(this.tBoperador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBoperador1;
        private TextBox tBoperador2;
        private TextBox tBresultado;
        private Button bTMultiplica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bTDivide;
        private Button bTResta;
        private Button bTSuma;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}