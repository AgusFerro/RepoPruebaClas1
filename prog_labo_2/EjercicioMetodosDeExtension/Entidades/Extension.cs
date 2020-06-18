using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public enum Estaciones 
        {Verano,Otono,Invierno,Primavera}

        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            string str;
            TimeSpan timeSpan = new TimeSpan();
            DateTime dateTime;
            switch (estacion)
            {
                case Estaciones.Verano:
                    dateTime = new DateTime(2020, 12, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Otono:
                    dateTime = new DateTime(2021, 3, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Invierno:
                    dateTime = new DateTime(2020, 6, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
                case Estaciones.Primavera:
                    dateTime = new DateTime(2020, 9, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
            }

            str = String.Format("Faltan {0} dias para el {1}", timeSpan.TotalDays, estacion);

            return str;
        }
    }
}
