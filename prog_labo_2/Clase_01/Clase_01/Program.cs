using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    class Program
    {
        //Ejercicio 1
        static void Main(string[] args)
        {
            string number;
            bool success = false;
            int numero;
            int max=0;
            int min=0;
            int promedio=0;
            int f = 0;

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine("Ingrese numero");
                number = Console.ReadLine();
                success = int.TryParse(number, out numero);
                if(success == true)
                {
                    if(f == 0)
                    {
                        max = numero;
                        min = numero;
                        f++;
                    }

                    if(max < numero)
                    {
                        max = numero;
                    }

                    if(min > numero)
                    {
                        min = numero;
                    }

                    promedio = promedio + numero;
                }
                
            }

            promedio = promedio / 5;

            Console.WriteLine("El valor maximo es: {0}", max);
            Console.WriteLine("El valor minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
