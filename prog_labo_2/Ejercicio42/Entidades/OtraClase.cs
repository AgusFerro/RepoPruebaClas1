using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                MiClase mc = new MiClase(0);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("Constructor OtraClase", e);
            }
        }
    }
}
