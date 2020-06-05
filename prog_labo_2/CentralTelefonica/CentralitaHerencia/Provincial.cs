using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Atributos
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        //protected Franja franjaHoraria;
        public Franja franjaHoraria;
        private string path;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.path;
                
            }
            set
            {
                this.path = value;
            }
        }

        #endregion

        #region Metodos

        public Provincial() : base()
        { }
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

            //cadenaProvincial.AppendLine($"Duracion : {this.Duracion}");
            //cadenaProvincial.AppendLine($"Numero de Destino : {this.NroDestino}");
            //cadenaProvincial.AppendLine($"Numero de Origen : {this.NroOrigen}");
            //cadenaProvincial.AppendLine($"Costo : {this.CostoLlamada}");
            //cadenaProvincial.AppendLine($"Franja : {this.franjaHoraria}");
            cadenaProvincial.AppendLine(base.Mostrar() + $"Franja : {this.franjaHoraria}");

            return cadenaProvincial.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
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

        public bool Guardar()
        {
            bool success;
            //string path = @"C:\Users\agusf\Source\Repos\CentralTelefonica\Provincial.xml";
            XmlTextWriter writer = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(this.GetType());

            try 
            {
                ser.Serialize(writer, this);
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = false;
            }
            finally
            {
                writer.Close();
            }
            return success;
        }

        public Provincial Leer()
        {
            XmlTextReader reader = new XmlTextReader(this.RutaDeArchivo);
            XmlSerializer ser = new XmlSerializer(this.GetType());
            Provincial dato = new Provincial();
            try
            {
                dato = (Provincial)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }

            return dato;
        }
        #endregion
    }
}
