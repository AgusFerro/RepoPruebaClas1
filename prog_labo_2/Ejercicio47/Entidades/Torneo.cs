using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }
        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            bool b = false;

            foreach(T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre}");

            foreach(T item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{equipo1.Nombre} " + $"{r.Next(0, 10)} - "+ $"{r.Next(0, 10)} "+ $"{equipo2.Nombre}");

            return sb.ToString();
        }

        public string JugarPartido()
        {
            Random r = new Random();

            return CalcularPartido(this.equipos[r.Next(0,this.equipos.Count-1)], this.equipos[r.Next(0, this.equipos.Count - 1)]);
        }
    }
}
