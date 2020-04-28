using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "asdf";
            libro[1] = "wert";
            libro[2] = "fghj";

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Es: {0}", libro[i]);
            }

            libro[1] = "yui";
            Console.WriteLine("Es: {0}", libro[1]);

            Console.WriteLine("Es: {0}", libro[5]);

            Console.ReadKey();

        }
    }
}
