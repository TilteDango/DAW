namespace Visual___Ejercicio_12
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
            this.tBunidad = new System.Windows.Forms.TextBox();
            this.tBResultado = new System.Windows.Forms.TextBox();
            this.rbCM = new System.Windows.Forms.RadioButton();
            this.rbPulgadas = new System.Windows.Forms.RadioButton();
            this.rbPie = new System.Windows.Forms.RadioButton();
            this.lUnidades = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBunidad
            // 
            this.tBunidad.Location = new System.Drawing.Point(70, 230);
            this.tBunidad.Name = "tBunidad";
            this.tBunidad.Size = new System.Drawing.Size(100, 23);
            this.tBunidad.TabIndex = 0;
            this.tBunidad.TextChanged += new System.EventHandler(this.tBunidad_TextChanged);
            // 
            // tBResultado
            // 
            this.tBResultado.Location = new System.Drawing.Point(553, 234);
            this.tBResultado.Name = "tBResultado";
            this.tBResultado.ReadOnly = true;
            this.tBResultado.Size = new System.Drawing.Size(100, 23);
            this.tBResultado.TabIndex = 0;
            // 
            // rbCM
            // 
            this.rbCM.AutoSize = true;
            this.rbCM.Checked = true;
            this.rbCM.Location = new System.Drawing.Point(331, 188);
            this.rbCM.Name = "rbCM";
            this.rbCM.Size = new System.Drawing.Size(90, 19);
            this.rbCM.TabIndex = 1;
            this.rbCM.TabStop = true;
            this.rbCM.Text = "Centimetros";
            this.rbCM.UseVisualStyleBackColor = true;
            this.rbCM.CheckedChanged += new System.EventHandler(this.rbCM_CheckedChanged);
            // 
            // rbPulgadas
            // 
            this.rbPulgadas.AutoSize = true;
            this.rbPulgadas.Location = new System.Drawing.Point(331, 234);
            this.rbPulgadas.Name = "rbPulgadas";
            this.rbPulgadas.Size = new System.Drawing.Size(73, 19);
            this.rbPulgadas.TabIndex = 2;
            this.rbPulgadas.Text = "Pulgadas";
            this.rbPulgadas.UseVisualStyleBackColor = true;
            this.rbPulgadas.CheckedChanged += new System.EventHandler(this.rbPulgadas_CheckedChanged);
            // 
            // rbPie
            // 
            this.rbPie.AutoSize = true;
            this.rbPie.Location = new System.Drawing.Point(331, 274);
            this.rbPie.Name = "rbPie";
            this.rbPie.Size = new System.Drawing.Size(46, 19);
            this.rbPie.TabIndex = 3;
            this.rbPie.Text = "Pies";
            this.rbPie.UseVisualStyleBackColor = true;
            this.rbPie.CheckedChanged += new System.EventHandler(this.rbPie_CheckedChanged);
            // 
            // lUnidades
            // 
            this.lUnidades.AutoSize = true;
            this.lUnidades.Location = new System.Drawing.Point(659, 238);
            this.lUnidades.Name = "lUnidades";
            this.lUnidades.Size = new System.Drawing.Size(0, 15);
            this.lUnidades.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conversor de unidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lUnidades);
            this.Controls.Add(this.rbPie);
            this.Controls.Add(this.rbPulgadas);
            this.Controls.Add(this.rbCM);
            this.Controls.Add(this.tBResultado);
            this.Controls.Add(this.tBunidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBunidad;
        private TextBox tBResultado;
        private RadioButton rbCM;
        private RadioButton rbPulgadas;
        private RadioButton rbPie;
        private Label lUnidades;
        private Label label2;
    }
}