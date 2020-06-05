using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        #region Atributos
        //protected float costo;
        public float costo;
        private string path;
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
                return this.path;
            } 
            set 
            {
                this.path = value;
            }
        }
        #endregion

        #region Metodos
        public Local() : base()
        { }
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
            bool success;
            //string path = @"C:\Users\agusf\Source\Repos\CentralTelefonica\Local.xml";
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

        public Local Leer()
        {
            XmlTextReader reader = new XmlTextReader(this.RutaDeArchivo);
            XmlSerializer ser = new XmlSerializer(this.GetType());
            Local dato = new Local();
            try
            {
                dato = (Local)ser.Deserialize(reader);

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
