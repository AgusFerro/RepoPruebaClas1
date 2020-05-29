using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool succes = false;
            if(validaExistencia == true)
            {
                if (File.Exists(ruta) == true) 
                {
                    succes = true;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            return succes;
        }
    }
}
