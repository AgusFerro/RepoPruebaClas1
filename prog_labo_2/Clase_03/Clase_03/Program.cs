using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 16

            string alumnoA;
            string alumnoB;
            string alumnoC;

            Alumno a = new Alumno();
            a.nombre = "Agustin";
            a.apellido = "Ferro";
            a.legajo = 1;
            a.Estudiar(7, 6);
            a.CalcularFinal();
            alumnoA = a.Mostrar();
            Console.WriteLine(alumnoA);

            Alumno b = new Alumno();
            b.nombre = "Alan";
            b.apellido = "Rodriguez";
            b.legajo = 2;
            b.Estudiar(4, 2);
            b.CalcularFinal();
            alumnoB = b.Mostrar();
            Console.WriteLine(alumnoB);

            Alumno c = new Alumno();
            c.nombre = "Lucas";
            c.apellido = "Dominguez";
            c.legajo = 1;
            c.Estudiar(4, 5);
            c.CalcularFinal();
            alumnoC = c.Mostrar();
            Console.WriteLine(alumnoC);

            Console.ReadKey();

            //**********************************************************************************

            //Ejercicio 17
        }
    }
}
