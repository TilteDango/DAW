namespace Visual___Ejercicio_14
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
            this.components = new System.ComponentModel.Container();
            this.cBprimero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bNueva = new System.Windows.Forms.Button();
            this.cBsegundo = new System.Windows.Forms.ComboBox();
            this.lResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAleatoria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cBprimero
            // 
            this.cBprimero.FormattingEnabled = true;
            this.cBprimero.Location = new System.Drawing.Point(105, 138);
            this.cBprimero.Name = "cBprimero";
            this.cBprimero.Size = new System.Drawing.Size(171, 23);
            this.cBprimero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creador de Peliculas";
            // 
            // bNueva
            // 
            this.bNueva.Location = new System.Drawing.Point(298, 328);
            this.bNueva.Name = "bNueva";
            this.bNueva.Size = new System.Drawing.Size(162, 31);
            this.bNueva.TabIndex = 2;
            this.bNueva.Text = "Generar nueva película";
            this.bNueva.UseVisualStyleBackColor = true;
            this.bNueva.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBsegundo
            // 
            this.cBsegundo.FormattingEnabled = true;
            this.cBsegundo.Location = new System.Drawing.Point(460, 138);
            this.cBsegundo.Name = "cBsegundo";
            this.cBsegundo.Size = new System.Drawing.Size(171, 23);
            this.cBsegundo.TabIndex = 0;
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.BackColor = System.Drawing.SystemColors.Control;
            this.lResultado.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lResultado.Location = new System.Drawing.Point(174, 217);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 60);
            this.lResultado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 60);
            this.label2.TabIndex = 1;
            // 
            // bAleatoria
            // 
            this.bAleatoria.Location = new System.Drawing.Point(298, 379);
            this.bAleatoria.Name = "bAleatoria";
            this.bAleatoria.Size = new System.Drawing.Size(162, 31);
            this.bAleatoria.TabIndex = 2;
            this.bAleatoria.Text = "Generar película aleatoria";
            this.bAleatoria.UseVisualStyleBackColor = true;
            this.bAleatoria.Click += new System.EventHandler(this.bAleatoria_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAleatoria);
            this.Controls.Add(this.bNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBsegundo);
            this.Controls.Add(this.cBprimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cBprimero;
        private Label label1;
        private Button bNueva;
        private ComboBox cBsegundo;
        private Label lResultado;
        private Label label2;
        private Button bAleatoria;
        private System.Windows.Forms.Timer timer1;
    }
}