namespace Visual___Ejercicio11
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
            this.nUDdados = new System.Windows.Forms.NumericUpDown();
            this.nUDcaras = new System.Windows.Forms.NumericUpDown();
            this.lBdados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDdados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDcaras)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDdados
            // 
            this.nUDdados.Location = new System.Drawing.Point(121, 158);
            this.nUDdados.Name = "nUDdados";
            this.nUDdados.Size = new System.Drawing.Size(149, 23);
            this.nUDdados.TabIndex = 0;
            // 
            // nUDcaras
            // 
            this.nUDcaras.Location = new System.Drawing.Point(121, 300);
            this.nUDcaras.Name = "nUDcaras";
            this.nUDcaras.Size = new System.Drawing.Size(149, 23);
            this.nUDcaras.TabIndex = 0;
            // 
            // lBdados
            // 
            this.lBdados.FormattingEnabled = true;
            this.lBdados.ItemHeight = 15;
            this.lBdados.Location = new System.Drawing.Point(409, 1);
            this.lBdados.Name = "lBdados";
            this.lBdados.Size = new System.Drawing.Size(392, 394);
            this.lBdados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "La suma de los dados es: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tira Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione los dados a tirar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(121, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de caras";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tirar dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSuma
            // 
            this.lSuma.AutoSize = true;
            this.lSuma.Location = new System.Drawing.Point(560, 416);
            this.lSuma.Name = "lSuma";
            this.lSuma.Size = new System.Drawing.Size(0, 15);
            this.lSuma.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBdados);
            this.Controls.Add(this.nUDcaras);
            this.Controls.Add(this.nUDdados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDdados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDcaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nUDdados;
        private NumericUpDown nUDcaras;
        private ListBox lBdados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label lSuma;
    }
}