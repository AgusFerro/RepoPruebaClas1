using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Paciente))]
    [XmlInclude(typeof(Especialista))]
    public abstract class Persona
    {
        #region Atributos
        private int id;
        private string apellido;
        private string nombre;
        private int edad;
        private string sexo;
        private string direccion;
        #endregion

        #region Propiedades
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = ValidarEdad(value);
            }
        }
        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        #endregion

        #region Metodos
        public Persona()
        { }
        public Persona(int id, string apellido, string nombre, int edad, string sexo, string direccion) : this()
        {
            this.Id = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Direccion = direccion;
        }
        /// <summary>
        /// Metodo que valida el Nombre o Apellido de la Persona
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if ((Regex.IsMatch(dato, @"^[a-zA-Z]+$")) == true)
            {
                return dato;
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// Metodo que valida la Edad de una Persona
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        private int ValidarEdad(int edad) 
        {
            int retorno;

            if(edad < 0 || edad > 100)
            {
                retorno = 0;
            }
            else
            {
                retorno = edad;
            }

            return retorno;
        }
        #endregion
    }
}
