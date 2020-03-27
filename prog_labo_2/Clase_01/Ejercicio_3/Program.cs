using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        //Ejercicio 3
        static void Main(string[] args)
        {
            string number;
            int numero;
            bool success;

            Console.WriteLine("Ingrese un numero");
            number = Console.ReadLine();
            success = int.TryParse(number, out numero);
            if(success == true && numero > 0) 
            {
                for(int i=1;i<(numero+1);i++)
                {
                    int a = 0;
                    for (int j = 1; j < (i + 1); j++)
                    {
                        if (i % j == 0)
                        {
                            a++;
                        }
                    }
                    if (a == 2)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
