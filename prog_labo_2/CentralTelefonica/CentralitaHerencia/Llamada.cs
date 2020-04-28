using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region Atributos
        public enum TipoLlamada
        {
            Local,Provincial,Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propiedades

        public abstract float CostoLlamada
        {
            get;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
            
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
            
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
            
        }
        #endregion

        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden = -1;

            if(llamada1.Duracion > llamada2.Duracion)
            {
                orden = 1;
            }
            else if (llamada1.Duracion == llamada2.Duracion)
            {
                orden = 0;
            }

            return orden;
        }

        protected virtual string Mostrar() 
        {
            StringBuilder cadenaLlamada = new StringBuilder();

            cadenaLlamada.AppendLine($"Duracion : {this.Duracion}");
            cadenaLlamada.AppendLine($"Numero de Destino : {this.NroDestino}");
            cadenaLlamada.AppendLine($"Numero de Origen : {this.NroOrigen}");
            cadenaLlamada.AppendLine($"Costo de llamada: {this.CostoLlamada}");

            return cadenaLlamada.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool b;
            if (l1.Equals(l2))
            {
                b = true;
            }
            else
            {
                b = false;
            }

            return b;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            bool b;
            if (l1.Equals(l2))
            {
                b = false;
            }
            else
            {
                b = true;
            }

            return b;
        }
        #endregion
    }
}
