using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    //Ejercicio 6
    class Program
    {
        static void Main(string[] args)
        {
            int numA;
            int numB;
            bool sucA;
            bool sucB;
            string numberA;
            string numberB;

            Console.WriteLine("Ingrese un año inicial");
            numberA = Console.ReadLine();
            sucA = int.TryParse(numberA, out numA);
            while (sucA == false || numA < 0)
            {
                Console.WriteLine("ERROR, Reingrese el año");
                numberA = Console.ReadLine();
                sucA = int.TryParse(numberA, out numA);

            }

            Console.WriteLine("Ingrese un año final");
            numberB = Console.ReadLine();
            sucB = int.TryParse(numberB, out numB);
            while (sucB == false || numB < 0)
            {
                Console.WriteLine("ERROR, Reingrese el año");
                numberB = Console.ReadLine();
                sucB = int.TryParse(numberB, out numB);

            }

            for(int i = numA; i<=numB; i++)
            {
                if (i%4==0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine(i+" es año bisiesto");
                        }
                    }
                    else
                    {
                        Console.WriteLine(i + " es año bisiesto");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
