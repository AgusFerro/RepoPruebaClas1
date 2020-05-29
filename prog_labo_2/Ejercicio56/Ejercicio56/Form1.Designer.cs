namespace Ejercicio56
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoMenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoMenuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoMenuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraDeEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenu
            // 
            this.archivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenuAbrir,
            this.archivoMenuGuardar,
            this.archivoMenuGuardarComo});
            this.archivoMenu.Name = "archivoMenu";
            this.archivoMenu.Size = new System.Drawing.Size(60, 20);
            this.archivoMenu.Text = "Archivo";
            // 
            // archivoMenuAbrir
            // 
            this.archivoMenuAbrir.Name = "archivoMenuAbrir";
            this.archivoMenuAbrir.Size = new System.Drawing.Size(180, 22);
            this.archivoMenuAbrir.Text = "Abrir";
            this.archivoMenuAbrir.Click += new System.EventHandler(this.archivoMenuAbrir_Click);
            // 
            // archivoMenuGuardar
            // 
            this.archivoMenuGuardar.Name = "archivoMenuGuardar";
            this.archivoMenuGuardar.Size = new System.Drawing.Size(180, 22);
            this.archivoMenuGuardar.Text = "Guardar";
            this.archivoMenuGuardar.Click += new System.EventHandler(this.archivoMenuGuardar_Click);
            // 
            // archivoMenuGuardarComo
            // 
            this.archivoMenuGuardarComo.Name = "archivoMenuGuardarComo";
            this.archivoMenuGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.archivoMenuGuardarComo.Text = "Guardar como...";
            this.archivoMenuGuardarComo.Click += new System.EventHandler(this.archivoMenuGuardarComo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraDeEstado
            // 
            this.barraDeEstado.Name = "barraDeEstado";
            this.barraDeEstado.Size = new System.Drawing.Size(69, 17);
            this.barraDeEstado.Text = "0 caracteres";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 404);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuAbrir;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuGuardar;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuGuardarComo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barraDeEstado;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

