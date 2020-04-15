using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static void SetCotizacion (double cotizacion)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        //
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        //

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return aux;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return aux;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }

        //
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1 == d2;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1 != d2;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return d != (Dolar)e;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return d != (Dolar)p;
        }


    }
}
