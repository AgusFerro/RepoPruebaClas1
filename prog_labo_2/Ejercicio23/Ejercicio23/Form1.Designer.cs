namespace Ejercicio23
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
            this.Candado = new System.Windows.Forms.Button();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.textEuro = new System.Windows.Forms.TextBox();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.textPesos = new System.Windows.Forms.TextBox();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.textCotizacionEuro = new System.Windows.Forms.TextBox();
            this.textCotizacionDolar = new System.Windows.Forms.TextBox();
            this.textCotizacionPesos = new System.Windows.Forms.TextBox();
            this.textEuroAEuro = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textEuroADolar = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textEuroAPesos = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pesos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Candado
            // 
            this.Candado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Candado.Image = global::Ejercicio23.Properties.Resources.bloqueado;
            this.Candado.Location = new System.Drawing.Point(248, 12);
            this.Candado.Name = "Candado";
            this.Candado.Size = new System.Drawing.Size(75, 51);
            this.Candado.TabIndex = 0;
            this.Candado.Text = "Candado";
            this.Candado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Candado.UseVisualStyleBackColor = true;
            this.Candado.Click += new System.EventHandler(this.Candado_Click);
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(248, 91);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 1;
            this.btnConvertEuro.Text = "----->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // textEuro
            // 
            this.textEuro.Location = new System.Drawing.Point(110, 93);
            this.textEuro.Name = "textEuro";
            this.textEuro.Size = new System.Drawing.Size(100, 20);
            this.textEuro.TabIndex = 2;
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(248, 158);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 3;
            this.btnConvertDolar.Text = "----->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            // 
            // textDolar
            // 
            this.textDolar.Location = new System.Drawing.Point(110, 160);
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(100, 20);
            this.textDolar.TabIndex = 4;
            // 
            // textPesos
            // 
            this.textPesos.Location = new System.Drawing.Point(110, 227);
            this.textPesos.Name = "textPesos";
            this.textPesos.Size = new System.Drawing.Size(100, 20);
            this.textPesos.TabIndex = 5;
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(248, 225);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 6;
            this.btnConvertPesos.Text = "----->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            // 
            // textCotizacionEuro
            // 
            this.textCotizacionEuro.Location = new System.Drawing.Point(389, 29);
            this.textCotizacionEuro.Name = "textCotizacionEuro";
            this.textCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionEuro.TabIndex = 7;
            this.textCotizacionEuro.Leave += new System.EventHandler(this.textCotizacionEuro_Leave);
            // 
            // textCotizacionDolar
            // 
            this.textCotizacionDolar.Location = new System.Drawing.Point(552, 29);
            this.textCotizacionDolar.Name = "textCotizacionDolar";
            this.textCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionDolar.TabIndex = 8;
            this.textCotizacionDolar.Leave += new System.EventHandler(this.textCotizacionDolar_Leave);
            // 
            // textCotizacionPesos
            // 
            this.textCotizacionPesos.Location = new System.Drawing.Point(711, 29);
            this.textCotizacionPesos.Name = "textCotizacionPesos";
            this.textCotizacionPesos.Size = new System.Drawing.Size(100, 20);
            this.textCotizacionPesos.TabIndex = 9;
            this.textCotizacionPesos.Leave += new System.EventHandler(this.textCotizacionPesos_Leave);
            // 
            // textEuroAEuro
            // 
            this.textEuroAEuro.Location = new System.Drawing.Point(389, 94);
            this.textEuroAEuro.Name = "textEuroAEuro";
            this.textEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.textEuroAEuro.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(389, 160);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(389, 225);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textEuroADolar
            // 
            this.textEuroADolar.Location = new System.Drawing.Point(552, 91);
            this.textEuroADolar.Name = "textEuroADolar";
            this.textEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.textEuroADolar.TabIndex = 13;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(552, 158);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 14;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(552, 225);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 15;
            // 
            // textEuroAPesos
            // 
            this.textEuroAPesos.Location = new System.Drawing.Point(711, 90);
            this.textEuroAPesos.Name = "textEuroAPesos";
            this.textEuroAPesos.Size = new System.Drawing.Size(100, 20);
            this.textEuroAPesos.TabIndex = 16;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(711, 158);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 17;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(711, 225);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cotizacion\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dolar";
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Location = new System.Drawing.Point(24, 234);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(36, 13);
            this.Pesos.TabIndex = 22;
            this.Pesos.Text = "Pesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dolar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pesos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textEuroAPesos);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textEuroADolar);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textEuroAEuro);
            this.Controls.Add(this.textCotizacionPesos);
            this.Controls.Add(this.textCotizacionDolar);
            this.Controls.Add(this.textCotizacionEuro);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.textPesos);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.textEuro);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.Candado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Candado;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.TextBox textEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.TextBox textDolar;
        private System.Windows.Forms.TextBox textPesos;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.TextBox textCotizacionEuro;
        private System.Windows.Forms.TextBox textCotizacionDolar;
        private System.Windows.Forms.TextBox textCotizacionPesos;
        private System.Windows.Forms.TextBox textEuroAEuro;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textEuroADolar;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textEuroAPesos;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

