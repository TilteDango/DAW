namespace Visual___Ejercicio10
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
            this.lBGuarda = new System.Windows.Forms.ListBox();
            this.tBspain = new System.Windows.Forms.TextBox();
            this.tBen = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBGuarda
            // 
            this.lBGuarda.FormattingEnabled = true;
            this.lBGuarda.ItemHeight = 15;
            this.lBGuarda.Location = new System.Drawing.Point(223, 135);
            this.lBGuarda.Name = "lBGuarda";
            this.lBGuarda.Size = new System.Drawing.Size(290, 139);
            this.lBGuarda.TabIndex = 0;
            this.lBGuarda.SelectedIndexChanged += new System.EventHandler(this.lBGuarda_SelectedIndexChanged);
            // 
            // tBspain
            // 
            this.tBspain.Location = new System.Drawing.Point(111, 325);
            this.tBspain.Name = "tBspain";
            this.tBspain.Size = new System.Drawing.Size(108, 23);
            this.tBspain.TabIndex = 1;
            this.tBspain.TextChanged += new System.EventHandler(this.tBspain_TextChanged);
            // 
            // tBen
            // 
            this.tBen.Location = new System.Drawing.Point(515, 325);
            this.tBen.Name = "tBen";
            this.tBen.Size = new System.Drawing.Size(106, 23);
            this.tBen.TabIndex = 2;
            this.tBen.TextChanged += new System.EventHandler(this.tBen_TextChanged);
            // 
            // bEnviar
            // 
            this.bEnviar.Enabled = false;
            this.bEnviar.Location = new System.Drawing.Point(233, 380);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 23);
            this.bEnviar.TabIndex = 3;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Enabled = false;
            this.bBorrar.Location = new System.Drawing.Point(438, 380);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palabra en español";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Palabra en ingles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "CreaDiccionario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tBen);
            this.Controls.Add(this.tBspain);
            this.Controls.Add(this.lBGuarda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lBGuarda;
        private TextBox tBspain;
        private TextBox tBen;
        private Button bEnviar;
        private Button bBorrar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}