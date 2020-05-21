using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public abstract string Nombre
        {
            get;
        }

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool b = false;

            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                b = true;
            }

            return b;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public virtual string Ficha()
        {
            string s = String.Format("{0} fundado el {1}",this.nombre, this.fechaCreacion);

            return s;
        }
    }
}
