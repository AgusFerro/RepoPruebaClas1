using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        //Ejercicio 2
        static void Main(string[] args)
        {
            string number;
            int numero;
            bool success;
            double alCuadrado;
            double alCubo;

            Console.WriteLine("Ingrese un numero");

            number = Console.ReadLine();
            success = int.TryParse(number, out numero);

            while (success == false || numero < 0)
            {
                Console.WriteLine("ERROR, Reingrese el numero");
                number = Console.ReadLine();
                success = int.TryParse(number, out numero);

            }

            alCuadrado = Math.Pow(numero, 2);
            alCubo = Math.Pow(numero, 3);

            Console.WriteLine("{0} al cuadrado es: {1}", numero, alCuadrado);
            Console.WriteLine("{0} al cubo es: {1}", numero, alCubo);

            Console.ReadKey();
            
        }
    }
}
