using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        public enum Color
        {Roja,Blanca,Amarilla,Rosa,Azul}
        private Color florColor;

        /// <summary>
        /// retorna verdadero porque tiene flores
        /// </summary>
        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }
        /// <summary>
        /// retorna falso porque no tiene frutos
        /// </summary>
        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// constructor de la clase Rosal que llama al otro constructor de su misma clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Rosal(string nombre, int tamanio) : this(nombre,tamanio,Color.Roja)
        { }

        /// <summary>
        /// constructor de la clase Rosal, que llama al constructor de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        /// <param name="color"></param>
        public Rosal(string nombre, int tamanio,Color color) : base(nombre,tamanio)
        {
            this.florColor = color;
        }

        /// <summary>
        /// metodo que sobrescribe al ResumenDeDatos de la clase base
        /// </summary>
        /// <returns></returns>
        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.florColor}");

            return sb.ToString();
        }
    }
}
