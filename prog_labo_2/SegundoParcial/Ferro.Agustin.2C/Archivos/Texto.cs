using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public sealed class Texto : IArchivos<string>
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
        public Texto()
        {
            this.Ruta = String.Format("{0}\\SegundoParcialUtn\\ArchivosClinica\\ErorresLog.txt", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
        public bool Guardar(string dato)
        {
            StreamWriter sw = new StreamWriter(this.Ruta,File.Exists(this.Ruta));
            bool success = false;
            try
            {
                sw.WriteLine(dato);
                success = true;
            }
            catch (Exception)
            {
                //Si aca me tira error, estoy cagado
            }
            finally
            {
                sw.Close();
            }
            return success;
        }

        public string Leer()
        {
            StreamReader sr = new StreamReader(this.Ruta);
            string dato;
            try
            {
                dato = sr.ReadToEnd();
            }
            catch (Exception)
            {
                dato = "";
            }
            finally
            {
                sr.Close();
            }
            return dato;
        }
    }

        #endregion
}
