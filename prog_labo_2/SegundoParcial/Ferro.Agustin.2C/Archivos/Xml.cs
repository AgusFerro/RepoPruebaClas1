using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Archivos
{
    public sealed class Xml<T> : IArchivos<T>
    {
        #region Atributos
        private string ruta;
        #endregion
        #region Propiedades
        public string Ruta
        { 
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }
        #endregion
        #region Metodos
        public bool Guardar(T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter writer = new XmlTextWriter(this.Ruta, Encoding.UTF8);
            bool success = false;
            try
            {
                ser.Serialize(writer, datos);
                success = true;
            }
            catch (Exception e)
            {
                throw new XmlException(e.Message, e);
            }
            finally
            {
                writer.Close();
            }
            return success;
        }

        public T Leer()
        {
            T dato;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(this.Ruta);

            try
            {
                dato = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new XmlException(e.Message,e);
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
