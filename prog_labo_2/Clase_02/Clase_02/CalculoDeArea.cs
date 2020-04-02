using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado( double lado)
        {
            double area;

            area = lado * lado;

            return area;
        }

        public static double CalcularTriangulo(double Base, double altura)
        {
            double area;

            area = (Base * altura)/2;

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area;

            area = Math.PI * (Math.Pow(radio, 2));

            return area;
        }
    }
}
