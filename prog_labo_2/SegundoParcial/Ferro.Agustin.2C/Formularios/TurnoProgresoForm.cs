using Entidades;
using EntidadesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class TurnoProgresoForm : Form
    {
        public delegate void encargadoLista();
        #region Atributos
        private BindingList<Turnos> listaTurnosRestantes = new BindingList<Turnos>();
        private Thread hiloAtender;
        #endregion
        #region Propiedades
        public BindingList<Turnos> ListaTurnosRestantes
        {
            get
            {
                return this.listaTurnosRestantes;
            }
            set
            {
                this.listaTurnosRestantes = value;
            }
        }
        public Turnos this[int index]
        {
            get
            {
                if (index >= 0 && index < this.listaTurnosRestantes.Count)
                {
                    return this.listaTurnosRestantes[index];
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion
        #region Metodos
        public TurnoProgresoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Asocia el EventoLista al manejador CambiarLabel, y ademas, ejecuta ese metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnoProgresoForm_Load(object sender, EventArgs e)
        {
            EventoLista += this.CambiarLabel;
            AgregarTurnoForm.EventoAgregarTurno += this.CambiarLabel;

            this.CambiarLabel();
        }
        /// <summary>
        /// Inicia el hilo para que se atienda un Paciente en los proximos 10 segundos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtender_Click(object sender, EventArgs e)
        {
            this.hiloAtender = new Thread(this.ComenzarAAtender);
            AgregarTurnoForm.listaDeHilos.Add(this.hiloAtender);
            this.hiloAtender.Start();
        }
        /// <summary>
        /// Cambia los label de los nombres de los pacientes mientras
        /// que haya turnos disponibles
        /// </summary>
        private void CambiarLabel()
        {
            //Valido que haya al menos un turno
            if(this.listaTurnosRestantes.Count > 0)
            {
                var auxPaciente = PacientesDAO.TraerPorId(this.listaTurnosRestantes[0].IdPaciente);
                if (auxPaciente is null)
                {
                    foreach (Paciente paciente in AgregarTurnoForm.ListaPacientesXml)
                    {
                        if (paciente.Id == this.listaTurnosRestantes[0].IdPaciente)
                        {
                            lblNombrePaciente.Text = String.Format($"{paciente.Apellido}, {paciente.Nombre}");
                            break;
                        }
                    }
                }
                else
                {
                    lblNombrePaciente.Text = String.Format($"{auxPaciente.Apellido}, {auxPaciente.Nombre}");
                }
            }
            //Si no existe, no muestro nada
            else
            {
                lblNombrePaciente.Text = "No hay paciente";
            }

            //Valido que haya al menos dos turnos
            if (this.listaTurnosRestantes.Count > 1)
            {
                var auxPaciente = PacientesDAO.TraerPorId(this.listaTurnosRestantes[1].IdPaciente);
                if (auxPaciente is null)
                {
                    foreach (Paciente paciente in AgregarTurnoForm.ListaPacientesXml)
                    {
                        if (paciente.Id == this.listaTurnosRestantes[1].IdPaciente)
                        {
                            lblNombreSigPaciente.Text = String.Format($"{paciente.Apellido}, {paciente.Nombre}");
                            break;
                        }
                    }
                }
                else
                {
                    lblNombreSigPaciente.Text = String.Format($"{auxPaciente.Apellido}, {auxPaciente.Nombre}");
                }
            }
            //Si no existe, no muestro nada
            else
            {
                lblNombreSigPaciente.Text = "No hay paciente";
            }

        }
        /// <summary>
        /// Invoco al evento para que en el formulario ListoTurnoForm, se mueva un turno de la cola
        /// a la lista de turnosTerminados
        /// </summary>
        private void ComenzarAAtender()
        {
            if (pgsBarTurno.InvokeRequired)
            {
                encargadoLista encargadoLista = new encargadoLista(this.ComenzarAAtender);
                this.Invoke(encargadoLista);
            }
            else
            {
                if (listaTurnosRestantes.Count > 0)
                {
                    lblAtenderAtendiendo.Text = "Atendiendo";
                    MessageBox.Show("Este proceso puede demorar unos segundos. Sea paciente...", "Atendiendo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    while (pgsBarTurno.Value < 100)
                    {
                        Thread.Sleep(1000);
                        pgsBarTurno.Value += 10;
                        if (pgsBarTurno.Value == 100)
                        {
                            EventoLista.Invoke();
                        }
                    }
                    pgsBarTurno.Value = 0;
                    lblAtenderAtendiendo.Text = "Atender";
                }
                else
                {
                    MessageBox.Show("No hay mas turnos", "Turnos");
                }
                
            }
        }
        #endregion
        public static event encargadoLista EventoLista;
    }
}
