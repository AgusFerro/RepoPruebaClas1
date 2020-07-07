using Entidades;
using EntidadesDAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;

namespace Formularios
{
    public partial class ListaTurnosForm : Form
    {
        public delegate void delegadoTurno();

        #region Atributos
        private BindingList<Turnos> colaTurnos;
        private BindingList<Turnos> turnosTerminados = new BindingList<Turnos>();
        public static int maxIdTurno;
        #endregion
        #region Propiedades
        public BindingList<Turnos> ColaTurnos
        {
            get
            {
                return this.colaTurnos;
            }
            set
            {
                this.colaTurnos = value;
            }
        }
        public BindingList<Turnos> TurnoTerminados
        {
            get
            {
                return this.turnosTerminados;
            }
            set
            {
                this.turnosTerminados = value;
            }
        }
        public Turnos this[int index]
        {
            get
            {
                if (index >= 0 && index < this.ColaTurnos.Count)
                {
                    return this.ColaTurnos[index];
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion
        #region Metodos
        public ListaTurnosForm()
        {
            this.colaTurnos = new BindingList<Turnos>();
            InitializeComponent();
        }
        /// <summary>
        /// Le harcodeo turnos a la Cola de turnos y asocio el EventoLista de TurnoProgresoForm
        /// al manejador DesplazarTurnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListaTurnosForm_Load(object sender, EventArgs e)
        {
            TurnoProgresoForm.EventoLista += DesplazarTurno;

            this.ColaTurnos.Add(new Turnos(2, 45, 4, "", DateTime.Now));
            this.ColaTurnos.Add(new Turnos(3, 56, 3, "", DateTime.Now));
            /*this.ColaTurnos.Add(new Turnos(4, 32, 10, "", DateTime.Now));
            this.ColaTurnos.Add(new Turnos(5, 17, 9,"", DateTime.Now));
            this.ColaTurnos.Add(new Turnos(6, 74, 8, "", DateTime.Now));
            this.ColaTurnos.Add(new Turnos(7, 1, 6, "", DateTime.Now));*/

            lstBoxTurnosRestantes.DataSource = this.ColaTurnos;
            lstBoxTurnosRestantes.DisplayMember = "IdTurno";

            this.TurnoTerminados.Add(new Turnos(1, 1, 1, "", DateTime.Now));
            lstBoxTurnosTerminados.DataSource = this.TurnoTerminados;
            lstBoxTurnosTerminados.DisplayMember = "IdTurno";
            
            maxIdTurno = (this.colaTurnos.Last()).IdTurno;
        }
        /// <summary>
        /// Mientras que haya al menos un turno en la cola de turnos,
        /// se le va a grabar una observacion, se agrega a la lista de turnos terminados
        /// y segun corresponda, se graba en un XML o en la base. Al final,
        /// se remueve el turno de la cola
        /// </summary>
        private void DesplazarTurno()
        {
            if (this.lstBoxTurnosTerminados.InvokeRequired)
            {
                delegadoTurno d = new delegadoTurno(this.DesplazarTurno);
                this.Invoke(d);
            }
            else
            {
                if(this.colaTurnos.Count > 0)
                {
                    this.Observacion(this[0]);
                    this.turnosTerminados.Add(this[0]);
                    this.GuardarTurnos(this[0]);
                    this.colaTurnos.RemoveAt(0);
                    this.ActualizarDisplayListas();
                }
            }
        }
        /// <summary>
        /// Actualiza la vista en las listBox correspondientes del Form
        /// </summary>
        private void ActualizarDisplayListas()
        {
            lstBoxTurnosTerminados.DataSource = this.TurnoTerminados;
            lstBoxTurnosTerminados.DisplayMember = "IdTurno";
            lstBoxTurnosRestantes.DataSource = this.ColaTurnos;
            lstBoxTurnosRestantes.DisplayMember = "IdTurno";
        }
        /// <summary>
        /// Si el paciente se encuentra en la base, se guarda el turno en la base. Sino, se graba en un XML
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        private bool GuardarTurnos(Turnos turno)
        {
            bool success = false;
            try
            {
                if (PacientesDAO.VerificarPorId(turno.IdPaciente))
                {
                    TurnosDAO.Insertar(turno);
                }
                else
                {
                    var auxPaciente = Paciente.BuscarPacienteEnListaXmlPorId(AgregarTurnoForm.ListaPacientesXml, turno.IdPaciente);
                    Xml<Turnos> xmlTurno = new Xml<Turnos>();
                    xmlTurno.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\{1}-{2}-{3}.xml", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), auxPaciente.Apellido,auxPaciente.Nombre,turno.FechaTurno.ToString("MMMM dd"));
                    xmlTurno.Guardar(turno);
                }
                success = true;
            }
            catch(Exception e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: GuardarTurnos()");
                success = false;
            }
            return success;

        }
        /// <summary>
        /// Metodo que graba una observacion en el turno, segun el campo del Especialista
        /// </summary>
        /// <param name="t"></param>
        private void Observacion(Turnos t)
        {
            foreach(Especialista especialista in AgregarTurnoForm.ListaEspecialistasXml)
            {
                if(especialista.Id == t.IdEspecialista)
                {
                    t.ObservacionTurno = especialista.ObservacionDelTurno();
                    //break;
                    return;
                }
            }

            var espeAux = EspecialistasDAO.TraerPorId(t.IdEspecialista);
            if (espeAux is Especialista)
            {
                t.ObservacionTurno = espeAux.ObservacionDelTurno();
            }
        }
        /// <summary>
        /// Guarda en un archivo binario un turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarBinario_Click(object sender, EventArgs e)
        {
            try
            {
                var auxTurno = (Turnos)lstBoxTurnosTerminados.SelectedItem;
                var auxPaciente = PacientesDAO.TraerPorId(auxTurno.IdPaciente);
                if (auxPaciente is null)
                {
                    auxPaciente = Paciente.BuscarPacienteEnListaXmlPorId(AgregarTurnoForm.ListaPacientesXml, auxTurno.IdPaciente);
                }

                Binario binarioTurno = new Binario();
                binarioTurno.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\{1}-{2}-{3}.bin", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), auxPaciente.Apellido, auxPaciente.Nombre, auxTurno.FechaTurno.ToString("MMMM dd"));
                bool success = binarioTurno.Guardar(auxTurno);
                if (!success)
                {
                    MessageBox.Show("No se pudo binarizar el turno");
                }
            }
            catch (Exception ex)
            {
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: btnGuardarBinario_Click()");
            }
        }
        #endregion
    }
}
