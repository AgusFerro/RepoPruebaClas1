using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase oc = new OtraClase();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                while (e.InnerException != null)
                {
                    e = e.InnerException;
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
