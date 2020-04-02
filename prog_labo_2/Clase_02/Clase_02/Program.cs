using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        /* Para probar los ejercicios, solamente comentar las lineas de codigo con sus variables ya que algunas 
           se encuentran repetidas */
        static void Main(string[] args)
        {

            //Ejercicio 11

            //string numero;
            //int number;
            //bool success;
            //int contador = 0;
            //int promedio = 0;
            //int min = 0;
            //int max = 0;
            //int flag = 0;

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

            //string numero;
            //int number;
            //bool success;
            //int acumulador = 0;
            //string s;
            //char[] c;

            //do
            //{
            //    Console.WriteLine("Ingrese numero");
            //    numero = Console.ReadLine();
            //    number = int.Parse(numero);
            //    acumulador = acumulador + number;
            //    Console.WriteLine("Desea continuar? (S/N)");
            //    s = Console.ReadLine();
            //    c = s.ToCharArray();

            //    success = ValidarRespuesta.ValidaS_N(c[0]);
            //} while (success == true);

            //Console.WriteLine("La suma de los numeros es {0}", acumulador);
            //Console.ReadKey();

            //******************************************************************************************************

            //Ejercicio 14

            string figura;

            do
            {
                Console.WriteLine("Ingrese una figura (cuadrado/triangulo/circulo)");
                figura = Console.ReadLine();

                if(figura == "cuadrado") 
                {
                    string lado;
                    double ladoD,area;

                    Console.WriteLine("Ingrese el lado del cuadrado");
                    lado = Console.ReadLine();
                    ladoD = Double.Parse(lado);
                    area = CalculoDeArea.CalcularCuadrado(ladoD);

                    Console.WriteLine("El area del cuadrado es: {0}", area);

                }
                else if (figura == "triangulo")
                {
                    string altura;
                    string Base;
                    double baseD, alturaD, area;

                    Console.WriteLine("Ingrese la base del triangulo");
                    Base = Console.ReadLine();
                    baseD = Double.Parse(Base);
                    Console.WriteLine("Ingrese la altura del triangulo");
                    altura = Console.ReadLine();
                    alturaD = Double.Parse(altura);

                    area = CalculoDeArea.CalcularTriangulo(baseD,alturaD);

                    Console.WriteLine("El area del triangulo es: {0}", area);
                }
                else if (figura == "circulo")
                {
                    string radio;
                    double radioD,area;

                    Console.WriteLine("Ingrese el radio del circulo");
                    radio = Console.ReadLine();
                    radioD = Double.Parse(radio);
                    area = CalculoDeArea.CalcularCuadrado(radioD);

                    Console.WriteLine("El area del circulo es: {0}", area);
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
            } while (figura != "cuadrado" && figura != "triangulo" && figura != "circulo");

            Console.ReadKey();
        }
    }
}
