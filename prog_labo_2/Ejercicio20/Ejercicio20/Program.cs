using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos pesos = new Pesos(10, 38.33);
            Dolar dolar = new Dolar(10);
            Euro euro = new Euro(10, 1.16);

            Console.WriteLine("-Dolar: " + Dolar.GetCotizacion() + "-Euro: " + Euro.GetCotizacion() + "-Pesos: " + Pesos.GetCotizacion());
            Console.ReadKey();

            Pesos pesos2 = pesos + dolar;
            Console.WriteLine("Pesos2: " + pesos2.GetCantidad());
            Console.ReadKey();
        }
    }
}
