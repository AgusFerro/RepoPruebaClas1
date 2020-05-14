using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        /// <summary>
        /// propiedad que devuelve el atributo tamanio
        /// </summary>
        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        /// <summary>
        /// propiedad abstracta a ser sobrescrita
        /// </summary>
        public abstract bool TieneFlores
        {
            get;
        }
        /// <summary>
        /// propiedad abstracta a ser sobrescrita
        /// </summary>
        public abstract bool TieneFruto
        {
            get;
        }
        /// <summary>
        /// constructor de la clase Planta
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        /// <summary>
        /// metodo virtual que devuelve en un string la informacion de la planta
        /// </summary>
        /// <returns></returns>
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} tiene un tamaño de {this.tamanio}");
            if(this.TieneFlores == true)
            {
                sb.AppendLine($"Tiene flores SI");
            }
            else
            {
                sb.AppendLine($"Tiene flores NO");
            }

            if(this.TieneFruto == true)
            {
                sb.AppendLine($"Tiene fruto SI");
            }
            else
            {
                sb.AppendLine($"Tiene fruto NO");
            }

            return sb.ToString();
        }
    }
}
