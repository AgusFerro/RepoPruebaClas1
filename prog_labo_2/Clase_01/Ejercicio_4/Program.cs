using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        //Ejercicio 4
        static void Main(string[] args)
        {
            int b,s,a,j;
            int contador=0;
            int i = 1;

            Console.WriteLine("Los primeros cuatro numeros perfectos son: ");
            do
            {
                b = 0;
                s = i / 2;

                for (j = 1; j <= s; j++)
                {

                    a = i % j;

                    if (a == 0)
                    {
                        b = b + j;
                    }
                }
                if (b == i)
                {
                    Console.WriteLine(i);
                    contador++;
                }
                i++;
            } while (contador < 4);

            Console.ReadKey();
        }
    }
}
