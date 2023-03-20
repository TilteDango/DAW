namespace Visual___Ejercicio_15
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFichero = new System.Windows.Forms.TextBox();
            this.bRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(22, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(455, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "LeeListaCSV";
            // 
            // tbFichero
            // 
            this.tbFichero.Location = new System.Drawing.Point(482, 157);
            this.tbFichero.Name = "tbFichero";
            this.tbFichero.Size = new System.Drawing.Size(263, 23);
            this.tbFichero.TabIndex = 2;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(549, 287);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(147, 71);
            this.bRun.TabIndex = 3;
            this.bRun.Text = "Cargar fichero";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbFichero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Label label1;
        private TextBox tbFichero;
        private Button bRun;
    }
}