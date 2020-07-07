using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Archivos;
using Entidades;
using EntidadesDAO;

namespace Formularios
{
    public partial class AgregarTurnoForm : Form
    {
        public delegate void agregarTurno();
        #region Atributos
        private static List<Paciente> listaPacientesXml;
        private static List<Especialista> listaEspecialistasXml;
        public static List<Thread> listaDeHilos;
        private TurnoProgresoForm turnoProgresoForm;
        private ListaTurnosForm listaTurnosForm;
        private Thread hilo;
        #endregion
        #region Propiedades
        public static List<Paciente> ListaPacientesXml
        {
            get
            {
                return listaPacientesXml;
            }
            /*set
            {
                listaPacientesXml = value;
            }*/
        }
        public static List<Especialista> ListaEspecialistasXml
        {
            get
            {
                return listaEspecialistasXml;
            }
            /*set
            {
                listaEspecialistasXml = value;
            }*/
        }
        #endregion
        #region Metodos
        public AgregarTurnoForm()
        {
            listaDeHilos = new List<Thread>();
            listaEspecialistasXml = new List<Especialista>();
            listaPacientesXml = new List<Paciente>();
            this.turnoProgresoForm = new TurnoProgresoForm();
            this.listaTurnosForm = new ListaTurnosForm();
            InitializeComponent();
        }
        /// <summary>
        /// Setea los comboBox y los radioButton, carga las listas desde los Xml y carga los dataGrid de la base.
        /// Inicia un subproceso con el cual le pasa la lista de turnos restantes del ListaTurnosForm
        /// a la lista de turnos del TurnoProgresoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarTurnoForm_Load(object sender, EventArgs e)
        {
            TurnoProgresoForm.EventoLista += ActualizarLista;

            rdoBtnInternoEspecialista.Checked = true;
            rdoBtnInternoPaciente.Checked = true;

            cmbCobertura.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(Especialista.EEspecialidad));

            this.CargarXml();
            this.CargarBase();

            hilo = new Thread(this.ActualizarLista);
            listaDeHilos.Add(hilo);
            hilo.Start();

            listaTurnosForm.Show();
            turnoProgresoForm.Show();
        }
        /// <summary>
        /// Carga las listas de Pacientes y Espcialistas desde los XML
        /// </summary>
        private void CargarXml()
        {
            //Pacientes
            Xml<List<Paciente>> xmlPacientes = new Xml<List<Paciente>>();
            xmlPacientes.Ruta = String.Format("{0}\\SegundoParcialUtn\\ArchivosClinica\\PacientesSegundaClinica.xml", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            try
            {
                listaPacientesXml = xmlPacientes.Leer();
                foreach (Paciente paciente in listaPacientesXml)
                {
                    //pregunto si ese paciente no esta en la base, y si no esta lo meto en la lista
                    if (!PacientesDAO.Comparar(paciente))
                    {
                        lstPacientesXml.Items.Add(paciente);
                    }
                }
                lstPacientesXml.DisplayMember = "Nombre";
            }
            catch (XmlException e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: CargarXml()");
                MessageBox.Show("No se pudo cargar la lista externa de Pacientes");
                rdoBtnExternoPaciente.Visible = false;
            }

            //Especialistas
            try
            {
                Xml<List<Especialista>> xmlEspecialistas = new Xml<List<Especialista>>();
                xmlEspecialistas.Ruta = String.Format("{0}\\SegundoParcialUtn\\ArchivosClinica\\DoctoresSegundaClinica.xml", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                listaEspecialistasXml = xmlEspecialistas.Leer();
                foreach (Especialista espe in listaEspecialistasXml)
                {
                    //pregunto si ese especialista no esta en la base, y si no esta lo meto en la lista
                    if (!EspecialistasDAO.Comparar(espe))
                    {
                        lstEspecialistaXml.Items.Add(espe);
                    }
                }
                lstEspecialistaXml.DisplayMember = "Nombre";
            }
            catch (XmlException e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: CargarXml()");
                MessageBox.Show("No se pudo cargar la lista externa de Especialistas");
                rdoBtnExternoEspecialista.Visible = false;
            }
        }
        /// <summary>
        /// Carga los dataGrid de Paciente y Especialistas desde la Base
        /// </summary>
        private void CargarBase()
        {
            //DataGrid de Pacientes
            SqlConnection sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
            SqlCommand sqlCommandPacientes = new SqlCommand("SELECT * FROM Pacientes WHERE obraSocial = @obraSocial",sqlConnection);
            SqlDataReader sqlDataReaderPacientes;
            DataTable tablaPacientes = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlCommandPacientes.Parameters.Clear();
                sqlCommandPacientes.Parameters.Add(new SqlParameter("obraSocial",cmbCobertura.SelectedItem.ToString()));
                sqlDataReaderPacientes = sqlCommandPacientes.ExecuteReader();
                tablaPacientes.Load(sqlDataReaderPacientes);
                dataGridPacientes.DataSource = tablaPacientes;
                dataGridPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch(Exception e)
            {
                MessageBox.Show("",e.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

            //DataGrid de Especialistas
            SqlCommand sqlCommandEspecialistas = new SqlCommand("SELECT * FROM Especialistas WHERE especialidad = @especialidad", sqlConnection);
            SqlDataReader sqlDataReaderEspecialistas;
            DataTable tablaEspecialistas = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlCommandEspecialistas.Parameters.Clear();
                sqlCommandEspecialistas.Parameters.Add(new SqlParameter("especialidad", cmbEspecialidad.SelectedItem.ToString()));
                sqlDataReaderEspecialistas = sqlCommandEspecialistas.ExecuteReader();
                tablaEspecialistas.Load(sqlDataReaderEspecialistas);
                dataGridEspecialistas.DataSource = tablaEspecialistas;
                dataGridEspecialistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception e)
            {
                MessageBox.Show("", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Le pasa al turnoProgresoForm la cola de turnos del listaTurnosForm
        /// </summary>
        private void ActualizarLista()
        {
            try
            {
                turnoProgresoForm.ListaTurnosRestantes = listaTurnosForm.ColaTurnos;
            }
            catch(Exception e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: ActualizarLista()");
            }

        }
        /// <summary>
        /// Agrega un turno a la cola de ListaTurnosForm
        /// </summary>
        public void AgregarTurno(Turnos turno)
        {
            listaTurnosForm.ColaTurnos.Add(turno);
            EventoAgregarTurno.Invoke();
        }
        /// <summary>
        /// Agrega un nuevo turno a la cola de listaTurnosForm,
        /// evaluando si el Paciente y Especialista proviene
        /// de la Base o del XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            int flag = ListaTurnosForm.maxIdTurno + 1;
            ListaTurnosForm.maxIdTurno++;
            Turnos turno;
            try
            {
                if (rdoBtnInternoPaciente.Checked && rdoBtnInternoEspecialista.Checked)
                {
                    turno = new Turnos(flag, int.Parse(dataGridPacientes.SelectedCells[0].Value.ToString()), int.Parse(dataGridEspecialistas.SelectedCells[0].Value.ToString()), "", DateTime.Now);
                    this.AgregarTurno(turno);
                }
                else if (rdoBtnInternoPaciente.Checked && rdoBtnExternoEspecialista.Checked)
                {
                    turno = new Turnos(flag, int.Parse(dataGridPacientes.SelectedCells[0].Value.ToString()), ((Especialista)lstEspecialistaXml.SelectedItem).Id, "", DateTime.Now);
                    this.AgregarTurno(turno);
                }
                else if (rdoBtnExternoPaciente.Checked && rdoBtnInternoEspecialista.Checked)
                {
                    turno = new Turnos(flag,((Paciente)lstPacientesXml.SelectedItem).Id, int.Parse(dataGridEspecialistas.SelectedCells[0].Value.ToString()), "", DateTime.Now);
                    this.AgregarTurno(turno);
                }
                else
                {
                    turno = new Turnos(flag, ((Paciente)lstPacientesXml.SelectedItem).Id, ((Especialista)lstEspecialistaXml.SelectedItem).Id, "", DateTime.Now);
                    this.AgregarTurno(turno);
                }
                
            }
            catch(Exception ex)
            {
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: btnAgregarTurno_Click");
                ListaTurnosForm.maxIdTurno--;
                MessageBox.Show("Controle que este seleccionando la celda correspondiente de la columna 'Id'");
            }
        }
        /// <summary>
        /// Segun el valor del enum EObraSocial, el dataGrid
        /// trae los pacientes que coincidan con la ObraSocial establecida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
            SqlCommand sqlCommandPacientes = new SqlCommand("SELECT * FROM Pacientes WHERE obraSocial = @obraSocial", sqlConnection);
            SqlDataReader sqlDataReaderPacientes;
            DataTable tablaPacientes = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlCommandPacientes.Parameters.Clear();
                sqlCommandPacientes.Parameters.Add(new SqlParameter("obraSocial", cmbCobertura.SelectedItem.ToString()));
                sqlDataReaderPacientes = sqlCommandPacientes.ExecuteReader();
                tablaPacientes.Load(sqlDataReaderPacientes);
                dataGridPacientes.DataSource = tablaPacientes;
                dataGridPacientes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Segun el valor del enum EEspecialidad, el dataGrid
        /// trae los especialista que coincidan con la Especialidad establecida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
            SqlCommand sqlCommandEspecialistas = new SqlCommand("SELECT * FROM Especialistas WHERE especialidad = @especialidad", sqlConnection);
            SqlDataReader sqlDataReaderEspecialistas;
            DataTable tablaEspecialistas = new DataTable();
            try
            {
                sqlConnection.Open();
                sqlCommandEspecialistas.Parameters.Clear();
                sqlCommandEspecialistas.Parameters.Add(new SqlParameter("especialidad", cmbEspecialidad.SelectedItem.ToString()));
                sqlDataReaderEspecialistas = sqlCommandEspecialistas.ExecuteReader();
                tablaEspecialistas.Load(sqlDataReaderEspecialistas);
                dataGridEspecialistas.DataSource = tablaEspecialistas;
                dataGridEspecialistas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Si esta presionado, utiliza los pacientes del dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoBtnInternoPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnInternoPaciente.Checked)
            {
                lstPacientesXml.Enabled = false;
                dataGridPacientes.Enabled = true;
            }
            else
            {
                lstPacientesXml.Enabled = true;
                dataGridPacientes.Enabled = false;
            }
        }
        /// <summary>
        /// Si esta presionado, utiliza los pacientes de la lista XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoBtnExternoPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnExternoPaciente.Checked)
            {
                lstPacientesXml.Enabled = true;
                dataGridPacientes.Enabled = false;
            }
            else
            {
                lstPacientesXml.Enabled = false;
                dataGridPacientes.Enabled = true;
            }
        }
        /// <summary>
        /// Si esta presionado, utiliza los especialistas del dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoBtnInternoEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnInternoEspecialista.Checked)
            {
                lstEspecialistaXml.Enabled = false;
                dataGridEspecialistas.Enabled = true;
            }
            else
            {
                lstEspecialistaXml.Enabled = true;
                dataGridEspecialistas.Enabled = false;
            }
        }
        /// <summary>
        /// Si esta presionado, utiliza los especialistas de la lista XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoBtnExternoEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnExternoEspecialista.Checked)
            {
                lstEspecialistaXml.Enabled = true;
                dataGridEspecialistas.Enabled = false;
            }
            else
            {
                lstEspecialistaXml.Enabled = false;
                dataGridEspecialistas.Enabled = true;
            }
        }
        /// <summary>
        /// Cuando se esta cerrando el formulario, aborta todos los hilos creados que sigan en ejecucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarTurnoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Thread hilo in listaDeHilos)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        #endregion
        public static event agregarTurno EventoAgregarTurno;
    }
}
