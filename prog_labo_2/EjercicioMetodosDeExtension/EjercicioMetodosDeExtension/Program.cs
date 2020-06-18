using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioMetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = DateTime.Now.ObtenerPlacaCronica(Extension.Estaciones.Verano);

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
