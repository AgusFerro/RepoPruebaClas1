using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodo();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public MiClase(int a)
        {
            try
            {
                MiClase mc = new MiClase();
            }
            catch(DivideByZeroException e)
            {
                throw new UnaExcepcion("Se ha lanzado una excepcion", e);
            }
        }
        public static void MiMetodo()
        {
            throw new DivideByZeroException("No se puede dividir por zero");
        }
    }
}
