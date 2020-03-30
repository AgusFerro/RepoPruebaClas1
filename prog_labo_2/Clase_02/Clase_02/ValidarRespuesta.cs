using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno = true;
            if (c != 'S')
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
