namespace Formularios
{
    partial class TurnoProgresoForm
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
            this.lblAtenderAtendiendo = new System.Windows.Forms.Label();
            this.lblSiguienteTurno = new System.Windows.Forms.Label();
            this.pgsBarTurno = new System.Windows.Forms.ProgressBar();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblNombreSigPaciente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAtenderAtendiendo
            // 
            this.lblAtenderAtendiendo.AutoSize = true;
            this.lblAtenderAtendiendo.Location = new System.Drawing.Point(12, 71);
            this.lblAtenderAtendiendo.Name = "lblAtenderAtendiendo";
            this.lblAtenderAtendiendo.Size = new System.Drawing.Size(44, 13);
            this.lblAtenderAtendiendo.TabIndex = 0;
            this.lblAtenderAtendiendo.Text = "Atender";
            // 
            // lblSiguienteTurno
            // 
            this.lblSiguienteTurno.AutoSize = true;
            this.lblSiguienteTurno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSiguienteTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSiguienteTurno.Location = new System.Drawing.Point(236, 71);
            this.lblSiguienteTurno.Name = "lblSiguienteTurno";
            this.lblSiguienteTurno.Size = new System.Drawing.Size(51, 13);
            this.lblSiguienteTurno.TabIndex = 1;
            this.lblSiguienteTurno.Text = "Siguiente";
            // 
            // pgsBarTurno
            // 
            this.pgsBarTurno.Location = new System.Drawing.Point(70, 163);
            this.pgsBarTurno.Name = "pgsBarTurno";
            this.pgsBarTurno.Size = new System.Drawing.Size(168, 37);
            this.pgsBarTurno.TabIndex = 2;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(107, 15);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 40);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(12, 100);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(35, 13);
            this.lblNombrePaciente.TabIndex = 4;
            this.lblNombrePaciente.Text = "label1";
            // 
            // lblNombreSigPaciente
            // 
            this.lblNombreSigPaciente.AutoSize = true;
            this.lblNombreSigPaciente.Location = new System.Drawing.Point(236, 100);
            this.lblNombreSigPaciente.Name = "lblNombreSigPaciente";
            this.lblNombreSigPaciente.Size = new System.Drawing.Size(35, 13);
            this.lblNombreSigPaciente.TabIndex = 5;
            this.lblNombreSigPaciente.Text = "label2";
            // 
            // TurnoProgresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.descarga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(314, 212);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombreSigPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.pgsBarTurno);
            this.Controls.Add(this.lblSiguienteTurno);
            this.Controls.Add(this.lblAtenderAtendiendo);
            this.Location = new System.Drawing.Point(1000, 430);
            this.Name = "TurnoProgresoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Progreso";
            this.Load += new System.EventHandler(this.TurnoProgresoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtenderAtendiendo;
        private System.Windows.Forms.Label lblSiguienteTurno;
        private System.Windows.Forms.ProgressBar pgsBarTurno;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblNombreSigPaciente;
    }
}