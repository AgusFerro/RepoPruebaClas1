using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public sealed class Turnos
    {
        #region Atributos
        private int idTurno;
        private int idPaciente;
        private int idEspecialista;
        private string observacionesTurno;
        private DateTime fechaTurno;
        #endregion
        #region Propiedades
        public int IdTurno 
        {
            get
            {
                return this.idTurno;
            }
            set
            {
                this.idTurno = value;
            }
        }
        public int IdPaciente
        {
            get
            {
                return this.idPaciente;
            }
            set
            {
                this.idPaciente = value;
            }
        }
        public int IdEspecialista
        {
            get
            {
                return this.idEspecialista;
            }
            set
            {
                this.idEspecialista = value;
            }
        }
        public string ObservacionTurno
        {
            get
            {
                return this.observacionesTurno;
            }
            set
            {
                this.observacionesTurno = value;
            }
        }
        public DateTime FechaTurno
        {
            get
            {
                return this.fechaTurno;
            }
            set
            {
                this.fechaTurno = value;
            }
        }
        #endregion
        #region Metodos
        public Turnos()
        { }
        public Turnos(int idTurno,int idPaciente,int idEspecialista, string observacionesTurno, DateTime fecha) : this()
        {
            this.IdTurno = idTurno;
            this.IdPaciente = idPaciente;
            this.IdEspecialista = idEspecialista;
            this.ObservacionTurno = observacionesTurno;
            this.FechaTurno = fecha;
        }
        #endregion
    }
}
