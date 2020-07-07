using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Especialista : Persona
    {
        #region Atributos
        public enum EEspecialidad
        {Psicologia,Dermatologia,Otorrinolaringologia,Ginecologia,Obtetricia,Pediatria,ClinicaGeneral,Oftalmologia}
        private EEspecialidad especialidad;
        #endregion
        #region Propiedades
        public EEspecialidad Especialidad 
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                this.especialidad = value;
            }
        }
        #endregion
        #region Metodos
        public Especialista() : base()
        { }
        public Especialista(int id, string apellido, string nombre, int edad, string sexo, string direccion, EEspecialidad especialidad) : base(id,apellido, nombre, edad, sexo, direccion)
        {
            this.Especialidad = especialidad;
        }
        /// <summary>
        /// Metodo estatico que me devuelve un Especialista de la listaXml por su Id
        /// </summary>
        /// <param name="listaEspecialistas"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Especialista BuscarEspecialistaEnListaXmlPorId(List<Especialista> listaEspecialistas, int id)
        {
            Especialista auxEspecialista = null;
            foreach (Especialista especialista in listaEspecialistas)
            {
                if (especialista.Id == id)
                {
                    auxEspecialista = especialista;
                }
            }
            return auxEspecialista;
        }
        #endregion
        #region Operadores
        /// <summary>
        /// Operador que devuelve true si dos Especialistas tienen el mismo Nombre, Apellido y Especialidad
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Especialista e1,Especialista e2)
        {
            bool success = false;
            if(e1.Especialidad == e2.Especialidad && e1.Apellido == e2.Apellido && e1.Nombre == e2.Nombre)
            {
                success = true;
            }
            return success;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Especialista e1, Especialista e2)
        {
            return !(e1 == e2);
        }

        /// <summary>
        /// Devuelve true si el Especialista trabaja en ese campo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="especialidad"></param>
        /// <returns></returns>
        public static bool operator ==(Especialista e, EEspecialidad especialidad)
        {
            bool success = false;
            if (e.Especialidad == especialidad)
            {
                success = true;
            }
            return success;
        }
        /// <summary>
        /// Devuelve true si el Especialista no trabaja en ese campo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="especialidad"></param>
        /// <returns></returns>
        public static bool operator !=(Especialista e, EEspecialidad especialidad)
        {
            return !(e == especialidad);
        }
        #endregion
    }
}
