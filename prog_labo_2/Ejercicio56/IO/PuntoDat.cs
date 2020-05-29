using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            bool success = false;
            Stream fs;
            BinaryFormatter ser = new BinaryFormatter();

            success = objeto.ValidarArchivo(ruta, true);
            fs = new FileStream(ruta, FileMode.Create);
            ser.Serialize(fs, objeto);
            fs.Close();

            return success;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            bool success = false;
            Stream fs;
            BinaryFormatter ser = new BinaryFormatter();

            fs = new FileStream(ruta, FileMode.Create);
            ser.Serialize(fs, objeto);
            fs.Close();
            success = true;

            return success;
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool success = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) == true)
                {
                    if(ruta.Contains(".dat") == true)
                    {
                        success = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat");
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }

            return success;
        }

    }
}
