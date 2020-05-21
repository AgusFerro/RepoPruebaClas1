using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> futbol = new Torneo<EquipoFutbol>("Futbol");
            Torneo<EquipoBasquet> basquet = new Torneo<EquipoBasquet>("Basquet");

            EquipoFutbol f1 = new EquipoFutbol("Boca",DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("Racing", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("Velez", DateTime.Now);

            EquipoBasquet b1 = new EquipoBasquet("Spurs", DateTime.Now);
            EquipoBasquet b2 = new EquipoBasquet("Chicago", DateTime.Now);
            EquipoBasquet b3 = new EquipoBasquet("Golden", DateTime.Now);

            futbol += f1;
            futbol += f2;
            futbol += f3;
            futbol += f1;

            basquet += b1;
            basquet += b2;
            basquet += b3;
            basquet += b1;

            Console.WriteLine(futbol.Mostrar());
            Console.ReadKey();

            Console.WriteLine(basquet.Mostrar());
            Console.ReadKey();

            Console.WriteLine(futbol.JugarPartido());
            Console.ReadKey();

            Console.WriteLine(basquet.JugarPartido());
            Console.ReadKey();

        }
    }
}
