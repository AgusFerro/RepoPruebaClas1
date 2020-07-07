using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Paciente : Persona
    {
        #region Atributos
        public enum EObraSocial 
        {NoTiene, CoberturaBasica, CoberturaCompleta}
        private EObraSocial obraSocial;
        #endregion
        #region Propiedades
        public EObraSocial ObraSocial
        {
            get
            {
                return this.obraSocial;
            }
            set
            {
                this.obraSocial = value;
            }
        }
        #endregion
        #region Metodos
        public Paciente() : base()
        { }
        public Paciente(int id, string apellido,string nombre,int edad,string sexo,string direccion, EObraSocial obraSocial) : base(id,apellido,nombre,edad,sexo,direccion)
        {
            this.ObraSocial = obraSocial;
        }
        #endregion
        /// <summary>
        /// Metodo estatico que permite buscar a un Paciente en la listaXml por su Id
        /// </summary>
        /// <param name="listaPacientes"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Paciente BuscarPacienteEnListaXmlPorId(List<Paciente> listaPacientes, int id)
        {
            Paciente auxPaciente = new Paciente();
            foreach(Paciente paciente in listaPacientes)
            {
                if(paciente.Id == id)
                {
                    auxPaciente = paciente;
                }
            }
            return auxPaciente;
        }
        #region Operadores
        /// <summary>
        /// Operador que devuelve true si el nombre, apellido y obraSocial de dos Personas coinciden
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paciente p1, Paciente p2)
        {
            bool success = false;
            if(p1.Nombre == p2.Nombre && p1.Apellido == p2.Apellido && p1.ObraSocial == p2.ObraSocial)
            {
                success = true;
            }

            return success;
        }
        /// <summary>
        /// Operador que devuelve true si al menos el nombre, apellido u obraSocial de dos Personas no coincide
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paciente p1, Paciente p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
