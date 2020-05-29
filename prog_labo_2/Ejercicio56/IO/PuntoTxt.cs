using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<PuntoTxt>
    {
        public bool Guardar(string ruta, PuntoTxt objeto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarComo(string ruta, PuntoTxt objeto)
        {
            throw new NotImplementedException();
        }

        public PuntoTxt Leer(string ruta)
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
                    if (ruta.Contains(".txt") == true)
                    {
                        success = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt");
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }

            return success;
        }
    }
}
