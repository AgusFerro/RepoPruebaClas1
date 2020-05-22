using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                float costo = CalcularCosto();
                return costo;
            }
        }

        public string RutaDeArchivo 
        { 
            get
            {
                return "";
            } 
            set 
            {

            }
        }
        #endregion

        #region Metodos
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino,costo)
        {  }

        private float CalcularCosto()
        {
            return (this.costo * this.Duracion);
        }

        protected override string Mostrar()
        {
            //StringBuilder cadenaLocal = new StringBuilder();

            ////cadenaLocal.AppendLine($"Duracion : {this.Duracion}");
            ////cadenaLocal.AppendLine($"Numero de Destino : {this.NroDestino}");
            ////cadenaLocal.AppendLine($"Numero de Origen : {this.NroOrigen}");   
            ////cadenaLocal.AppendLine($"Costo : {this.CostoLlamada}");

            //return cadenaLocal.ToString();
            return base.Mostrar();

        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool b = false;

            if(obj is Local)
            {
                b = true;
            }
            return b;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
