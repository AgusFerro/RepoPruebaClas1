using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region Atributos
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Metodos

        public Provincial(string origen, Franja miFranja , float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        { }

        private float CalcularCosto()
        {
            double costo = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.Duracion * 0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.Duracion * 1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.Duracion * 0.66;
                    break;
            }

            return (float)costo;
        }

        protected override string Mostrar()
        {
            StringBuilder cadenaProvincial = new StringBuilder();

            /*cadenaProvincial.AppendLine($"Duracion : {this.Duracion}");
            cadenaProvincial.AppendLine($"Numero de Destino : {this.NroDestino}");
            cadenaProvincial.AppendLine($"Numero de Origen : {this.NroOrigen}");  */
            cadenaProvincial.AppendLine($"Costo : {this.CostoLlamada}");
            cadenaProvincial.AppendLine($"Franja : {this.franjaHoraria}");

            return cadenaProvincial.ToString();
        }

        public override bool Equals(object obj)
        {
            bool b = false;

            if (obj is Provincial)
            {
                b = true;
            }
            return b;
        }
        #endregion
    }
}
