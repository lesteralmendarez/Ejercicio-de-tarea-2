namespace EJERCICIODETAREA2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PARCIAL1textBox = new System.Windows.Forms.TextBox();
            this.PARCIAL2textBox = new System.Windows.Forms.TextBox();
            this.PARCIAL3textBox = new System.Windows.Forms.TextBox();
            this.PARCIAL4textBox = new System.Windows.Forms.TextBox();
            this.PROMEDIObutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(96, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARCIAL 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PARCIAL 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARCIAL 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PARCIAL 4:";
            // 
            // PARCIAL1textBox
            // 
            this.PARCIAL1textBox.Location = new System.Drawing.Point(183, 96);
            this.PARCIAL1textBox.Name = "PARCIAL1textBox";
            this.PARCIAL1textBox.Size = new System.Drawing.Size(100, 22);
            this.PARCIAL1textBox.TabIndex = 4;
            // 
            // PARCIAL2textBox
            // 
            this.PARCIAL2textBox.Location = new System.Drawing.Point(183, 177);
            this.PARCIAL2textBox.Name = "PARCIAL2textBox";
            this.PARCIAL2textBox.Size = new System.Drawing.Size(100, 22);
            this.PARCIAL2textBox.TabIndex = 5;
            // 
            // PARCIAL3textBox
            // 
            this.PARCIAL3textBox.Location = new System.Drawing.Point(501, 95);
            this.PARCIAL3textBox.Name = "PARCIAL3textBox";
            this.PARCIAL3textBox.Size = new System.Drawing.Size(100, 22);
            this.PARCIAL3textBox.TabIndex = 6;
            // 
            // PARCIAL4textBox
            // 
            this.PARCIAL4textBox.Location = new System.Drawing.Point(501, 167);
            this.PARCIAL4textBox.Name = "PARCIAL4textBox";
            this.PARCIAL4textBox.Size = new System.Drawing.Size(100, 22);
            this.PARCIAL4textBox.TabIndex = 7;
            // 
            // PROMEDIObutton
            // 
            this.PROMEDIObutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PROMEDIObutton.Location = new System.Drawing.Point(304, 267);
            this.PROMEDIObutton.Name = "PROMEDIObutton";
            this.PROMEDIObutton.Size = new System.Drawing.Size(123, 56);
            this.PROMEDIObutton.TabIndex = 8;
            this.PROMEDIObutton.Text = "PROMEDIO";
            this.PROMEDIObutton.UseVisualStyleBackColor = true;
            this.PROMEDIObutton.Click += new System.EventHandler(this.PROMEDIObutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(42, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(657, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CALCULO DEL PROMEDIO DE LAS NOTAS DE LOS PARCIALES DEL ESTUDIANTE DE PROGRAMACION" +
    " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PROMEDIObutton);
            this.Controls.Add(this.PARCIAL4textBox);
            this.Controls.Add(this.PARCIAL3textBox);
            this.Controls.Add(this.PARCIAL2textBox);
            this.Controls.Add(this.PARCIAL1textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PARCIAL1textBox;
        private System.Windows.Forms.TextBox PARCIAL2textBox;
        private System.Windows.Forms.TextBox PARCIAL3textBox;
        private System.Windows.Forms.TextBox PARCIAL4textBox;
        private System.Windows.Forms.Button PROMEDIObutton;
        private System.Windows.Forms.Label label6;
    }
}

