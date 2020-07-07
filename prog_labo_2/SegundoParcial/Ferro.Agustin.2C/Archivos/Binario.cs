using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Entidades;
using System.Resources;

namespace Archivos
{
    public sealed class Binario : IArchivos<Turnos>
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
        public bool Guardar(Turnos turno)
        {
            bool success = false;
            FileStream fs = new FileStream(this.Ruta, FileMode.Append);
            BinaryFormatter ser = new BinaryFormatter();

            try
            {
                ser.Serialize(fs, turno);
                success = true;
            }
            catch (Exception e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: Binario.Guardar()");
                success = false;
            }
            finally
            {
                fs.Close();
            }
            return success;
        }

        public Turnos Leer()
        {
            Turnos dato = new Turnos();
            FileStream fs = new FileStream(this.Ruta, FileMode.Open);
            BinaryFormatter ser = new BinaryFormatter();

            try
            {
                dato = (Turnos)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: Binario.Leer()");
            }
            finally
            {
                fs.Close();
            }

            return dato;
        }
        #endregion
    }
}
