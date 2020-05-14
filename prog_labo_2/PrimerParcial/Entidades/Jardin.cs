using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo
        {Terrozo,Arenozo}
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public static Tipo Suelo
        {
            set
            {
                suelo = value;
            }
        }

        static Jardin()
        {
            Suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }
        
        public Jardin(int espacioTotal) :this()
        {
            this.espacioTotal = espacioTotal;
        }

        private int EspacioOcupado()
        {
            return EspacioOcupado(null);
        }

        private int EspacioOcupado(Planta planta)
        {
            int espacioOcupado = 0;
            
            foreach(Planta item in this.plantas)
            {
                espacioOcupado = espacioOcupado + item.Tamanio;
            }

            if(planta != null)
            {
                espacioOcupado = espacioOcupado + planta.Tamanio;
            }

            return espacioOcupado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Composicion del jardin: {suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");

            foreach(Planta item in this.plantas)
            {
                if(item is Rosal)
                {
                    sb.AppendLine(((Rosal)item).ResumenDeDatos());
                }
                else if (item is Banano)
                {
                    sb.AppendLine(((Banano)item).ResumenDeDatos());
                }
                if (item is Arbusto)
                {
                    sb.AppendLine(item.ResumenDeDatos());
                }
            }

            return sb.ToString();
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            bool succes = false;

            if (jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                succes = true;
                
            }

            return succes;
        }
    }
}
