using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 11
            string numero;
            int number;
            bool success;
            int contador = 0;
            int promedio = 0;
            int min = 0;
            int max = 0;
            int flag = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Ingrese numero: ");
            //    numero = Console.ReadLine();
            //    number = Int32.Parse(numero);

            //    success = Validacion.Validar(number, -100, 100);

            //    if (success == true)
            //    {
            //        contador++;
            //        promedio = promedio + number;

            //        if (flag == 0) 
            //        {
            //            min = number;
            //            max = number;
            //            flag++;
            //        }

            //        if (min > number)
            //        {
            //            min = number;
            //        }

            //        if (max < number)
            //        {
            //            max = number;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero no se encuentra dentro de los valores min y max");
            //    }
            //}

            //promedio = promedio / contador;

            //Console.WriteLine("El promedio es {0}",promedio);
            //Console.WriteLine("El numero min es {0}", min);
            //Console.WriteLine("El numero max es {0}", max);

            //Console.ReadKey();

            //******************************************************************************************************

            //Ejercicio 12

            string s;
            char[] c;

            do
            {
                Console.WriteLine("Ingrese numero");
                numero = Console.ReadLine();
                number = int.Parse(numero);
                contador = contador + number;
                Console.WriteLine("Desea continuar? (S/N)");
                s = Console.ReadLine();
                c = s.ToCharArray();

                success = ValidarRespuesta.ValidaS_N(c[0]);
            } while (success == true);

            Console.WriteLine("La suma de los numeros es {0}", contador);
            Console.ReadKey();
        }
    }
}
