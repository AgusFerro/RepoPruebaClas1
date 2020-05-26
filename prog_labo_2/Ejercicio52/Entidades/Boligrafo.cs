using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            int t = texto.Length;
            double unidades = texto.Length * 0.3;

            if(unidades < this.UnidadesDeEscritura)
            {
                this.UnidadesDeEscritura -= (float)unidades;
                return new EscrituraWrapper(texto, this.Color);
            }

            return null;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType()}");
            sb.AppendLine($"{this.Color}");
            sb.AppendLine($"{this.UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
