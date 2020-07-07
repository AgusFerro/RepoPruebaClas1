namespace Formularios
{
    partial class AgregarTurnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTurnoForm));
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBtnExternoEspecialista = new System.Windows.Forms.RadioButton();
            this.rdoBtnInternoEspecialista = new System.Windows.Forms.RadioButton();
            this.dataGridEspecialistas = new System.Windows.Forms.DataGridView();
            this.lblNombreEspecialista = new System.Windows.Forms.Label();
            this.lstEspecialistaXml = new System.Windows.Forms.ListBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBtnExternoPaciente = new System.Windows.Forms.RadioButton();
            this.rdoBtnInternoPaciente = new System.Windows.Forms.RadioButton();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lstPacientesXml = new System.Windows.Forms.ListBox();
            this.cmbCobertura = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecialistas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(603, 434);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(134, 62);
            this.btnAgregarTurno.TabIndex = 0;
            this.btnAgregarTurno.Text = "Agregar Turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(378, 66);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtnExternoEspecialista);
            this.groupBox1.Controls.Add(this.rdoBtnInternoEspecialista);
            this.groupBox1.Controls.Add(this.dataGridEspecialistas);
            this.groupBox1.Controls.Add(this.lblNombreEspecialista);
            this.groupBox1.Controls.Add(this.lstEspecialistaXml);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialista";
            // 
            // rdoBtnExternoEspecialista
            // 
            this.rdoBtnExternoEspecialista.AutoSize = true;
            this.rdoBtnExternoEspecialista.Location = new System.Drawing.Point(374, 128);
            this.rdoBtnExternoEspecialista.Name = "rdoBtnExternoEspecialista";
            this.rdoBtnExternoEspecialista.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnExternoEspecialista.TabIndex = 9;
            this.rdoBtnExternoEspecialista.TabStop = true;
            this.rdoBtnExternoEspecialista.Text = "Externo";
            this.rdoBtnExternoEspecialista.UseVisualStyleBackColor = true;
            this.rdoBtnExternoEspecialista.CheckedChanged += new System.EventHandler(this.rdoBtnExternoEspecialista_CheckedChanged);
            // 
            // rdoBtnInternoEspecialista
            // 
            this.rdoBtnInternoEspecialista.AutoSize = true;
            this.rdoBtnInternoEspecialista.Location = new System.Drawing.Point(373, 101);
            this.rdoBtnInternoEspecialista.Name = "rdoBtnInternoEspecialista";
            this.rdoBtnInternoEspecialista.Size = new System.Drawing.Size(58, 17);
            this.rdoBtnInternoEspecialista.TabIndex = 8;
            this.rdoBtnInternoEspecialista.TabStop = true;
            this.rdoBtnInternoEspecialista.Text = "Interno";
            this.rdoBtnInternoEspecialista.UseVisualStyleBackColor = true;
            this.rdoBtnInternoEspecialista.CheckedChanged += new System.EventHandler(this.rdoBtnInternoEspecialista_CheckedChanged);
            // 
            // dataGridEspecialistas
            // 
            this.dataGridEspecialistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecialistas.Location = new System.Drawing.Point(10, 35);
            this.dataGridEspecialistas.Name = "dataGridEspecialistas";
            this.dataGridEspecialistas.Size = new System.Drawing.Size(357, 150);
            this.dataGridEspecialistas.TabIndex = 7;
            // 
            // lblNombreEspecialista
            // 
            this.lblNombreEspecialista.AutoSize = true;
            this.lblNombreEspecialista.Location = new System.Drawing.Point(455, 105);
            this.lblNombreEspecialista.Name = "lblNombreEspecialista";
            this.lblNombreEspecialista.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEspecialista.TabIndex = 4;
            this.lblNombreEspecialista.Text = "Nombre";
            // 
            // lstEspecialistaXml
            // 
            this.lstEspecialistaXml.FormattingEnabled = true;
            this.lstEspecialistaXml.Location = new System.Drawing.Point(458, 128);
            this.lstEspecialistaXml.Name = "lstEspecialistaXml";
            this.lstEspecialistaXml.Size = new System.Drawing.Size(220, 43);
            this.lstEspecialistaXml.TabIndex = 3;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(378, 35);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBtnExternoPaciente);
            this.groupBox2.Controls.Add(this.rdoBtnInternoPaciente);
            this.groupBox2.Controls.Add(this.dataGridPacientes);
            this.groupBox2.Controls.Add(this.lblCobertura);
            this.groupBox2.Controls.Add(this.lblNombrePaciente);
            this.groupBox2.Controls.Add(this.lstPacientesXml);
            this.groupBox2.Controls.Add(this.cmbCobertura);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // rdoBtnExternoPaciente
            // 
            this.rdoBtnExternoPaciente.AutoSize = true;
            this.rdoBtnExternoPaciente.Location = new System.Drawing.Point(371, 121);
            this.rdoBtnExternoPaciente.Name = "rdoBtnExternoPaciente";
            this.rdoBtnExternoPaciente.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnExternoPaciente.TabIndex = 7;
            this.rdoBtnExternoPaciente.TabStop = true;
            this.rdoBtnExternoPaciente.Text = "Externo";
            this.rdoBtnExternoPaciente.UseVisualStyleBackColor = true;
            this.rdoBtnExternoPaciente.CheckedChanged += new System.EventHandler(this.rdoBtnExternoPaciente_CheckedChanged);
            // 
            // rdoBtnInternoPaciente
            // 
            this.rdoBtnInternoPaciente.AutoSize = true;
            this.rdoBtnInternoPaciente.Location = new System.Drawing.Point(373, 88);
            this.rdoBtnInternoPaciente.Name = "rdoBtnInternoPaciente";
            this.rdoBtnInternoPaciente.Size = new System.Drawing.Size(58, 17);
            this.rdoBtnInternoPaciente.TabIndex = 6;
            this.rdoBtnInternoPaciente.TabStop = true;
            this.rdoBtnInternoPaciente.Text = "Interno";
            this.rdoBtnInternoPaciente.UseVisualStyleBackColor = true;
            this.rdoBtnInternoPaciente.CheckedChanged += new System.EventHandler(this.rdoBtnInternoPaciente_CheckedChanged);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(10, 19);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(357, 150);
            this.dataGridPacientes.TabIndex = 4;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Location = new System.Drawing.Point(375, 21);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(53, 13);
            this.lblCobertura.TabIndex = 3;
            this.lblCobertura.Text = "Cobertura";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(479, 115);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePaciente.TabIndex = 2;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // lstPacientesXml
            // 
            this.lstPacientesXml.FormattingEnabled = true;
            this.lstPacientesXml.Location = new System.Drawing.Point(482, 131);
            this.lstPacientesXml.Name = "lstPacientesXml";
            this.lstPacientesXml.Size = new System.Drawing.Size(216, 43);
            this.lstPacientesXml.TabIndex = 1;
            // 
            // cmbCobertura
            // 
            this.cmbCobertura.FormattingEnabled = true;
            this.cmbCobertura.Location = new System.Drawing.Point(375, 50);
            this.cmbCobertura.Name = "cmbCobertura";
            this.cmbCobertura.Size = new System.Drawing.Size(121, 21);
            this.cmbCobertura.TabIndex = 0;
            this.cmbCobertura.SelectedIndexChanged += new System.EventHandler(this.cmbCobertura_SelectedIndexChanged);
            // 
            // AgregarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.galeno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(20, 100);
            this.Name = "AgregarTurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agregar Turno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarTurnoForm_FormClosing);
            this.Load += new System.EventHandler(this.AgregarTurnoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecialistas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreEspecialista;
        private System.Windows.Forms.ListBox lstEspecialistaXml;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.ListBox lstPacientesXml;
        private System.Windows.Forms.ComboBox cmbCobertura;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.DataGridView dataGridEspecialistas;
        private System.Windows.Forms.RadioButton rdoBtnExternoEspecialista;
        private System.Windows.Forms.RadioButton rdoBtnInternoEspecialista;
        private System.Windows.Forms.RadioButton rdoBtnExternoPaciente;
        private System.Windows.Forms.RadioButton rdoBtnInternoPaciente;
    }
}

