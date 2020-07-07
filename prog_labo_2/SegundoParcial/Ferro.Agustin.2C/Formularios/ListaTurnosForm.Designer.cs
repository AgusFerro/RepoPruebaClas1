namespace Formularios
{
    partial class ListaTurnosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTurnosRestantes = new System.Windows.Forms.Label();
            this.lblTurnosTerminados = new System.Windows.Forms.Label();
            this.lstBoxTurnosRestantes = new System.Windows.Forms.ListBox();
            this.lstBoxTurnosTerminados = new System.Windows.Forms.ListBox();
            this.btnGuardarBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnosRestantes
            // 
            this.lblTurnosRestantes.AutoSize = true;
            this.lblTurnosRestantes.Location = new System.Drawing.Point(27, 18);
            this.lblTurnosRestantes.Name = "lblTurnosRestantes";
            this.lblTurnosRestantes.Size = new System.Drawing.Size(91, 13);
            this.lblTurnosRestantes.TabIndex = 0;
            this.lblTurnosRestantes.Text = "Turnos Restantes";
            // 
            // lblTurnosTerminados
            // 
            this.lblTurnosTerminados.AutoSize = true;
            this.lblTurnosTerminados.Location = new System.Drawing.Point(30, 189);
            this.lblTurnosTerminados.Name = "lblTurnosTerminados";
            this.lblTurnosTerminados.Size = new System.Drawing.Size(95, 13);
            this.lblTurnosTerminados.TabIndex = 1;
            this.lblTurnosTerminados.Text = "Turnos Finalizados";
            // 
            // lstBoxTurnosRestantes
            // 
            this.lstBoxTurnosRestantes.FormattingEnabled = true;
            this.lstBoxTurnosRestantes.Location = new System.Drawing.Point(30, 49);
            this.lstBoxTurnosRestantes.Name = "lstBoxTurnosRestantes";
            this.lstBoxTurnosRestantes.Size = new System.Drawing.Size(249, 95);
            this.lstBoxTurnosRestantes.TabIndex = 2;
            // 
            // lstBoxTurnosTerminados
            // 
            this.lstBoxTurnosTerminados.FormattingEnabled = true;
            this.lstBoxTurnosTerminados.Location = new System.Drawing.Point(33, 220);
            this.lstBoxTurnosTerminados.Name = "lstBoxTurnosTerminados";
            this.lstBoxTurnosTerminados.Size = new System.Drawing.Size(246, 108);
            this.lstBoxTurnosTerminados.TabIndex = 3;
            // 
            // btnGuardarBinario
            // 
            this.btnGuardarBinario.Location = new System.Drawing.Point(320, 255);
            this.btnGuardarBinario.Name = "btnGuardarBinario";
            this.btnGuardarBinario.Size = new System.Drawing.Size(93, 36);
            this.btnGuardarBinario.TabIndex = 5;
            this.btnGuardarBinario.Text = "Guardar en Binario";
            this.btnGuardarBinario.UseVisualStyleBackColor = true;
            this.btnGuardarBinario.Click += new System.EventHandler(this.btnGuardarBinario_Click);
            // 
            // ListaTurnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(485, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarBinario);
            this.Controls.Add(this.lstBoxTurnosTerminados);
            this.Controls.Add(this.lstBoxTurnosRestantes);
            this.Controls.Add(this.lblTurnosTerminados);
            this.Controls.Add(this.lblTurnosRestantes);
            this.Location = new System.Drawing.Point(870, 20);
            this.Name = "ListaTurnosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.ListaTurnosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnosRestantes;
        private System.Windows.Forms.Label lblTurnosTerminados;
        private System.Windows.Forms.ListBox lstBoxTurnosRestantes;
        private System.Windows.Forms.ListBox lstBoxTurnosTerminados;
        private System.Windows.Forms.Button btnGuardarBinario;
    }
}