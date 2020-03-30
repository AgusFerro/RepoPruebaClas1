using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        //Ejercicio 7
        static void Main(string[] args)
        {
            int diasTotales = 0;

            Console.WriteLine("Ingresa dia de nacimiento");
            string diaDesde = Console.ReadLine();
            int diaDesdeNum = Int32.Parse(diaDesde);

            Console.WriteLine("Ingresa mes de nacimiento");
            string mesDesde = Console.ReadLine();
            int mesDesdeNum = Int32.Parse(mesDesde);

            Console.WriteLine("Ingresa año de nacimiento");
            string anoDesde = Console.ReadLine();
            int anoDesdeNum = Int32.Parse(anoDesde);

            //*********************************************************
            string fechaHasta = DateTime.Now.Date.ToString("yyyy/MM/dd");
            char del = '/';
            string[] values = fechaHasta.Split(del);

            int anoHasta = Int32.Parse(values[0]);
            int mesHasta = Int32.Parse(values[1]);
            int diaHasta = Int32.Parse(values[2]);

            for (int i = anoDesdeNum; i < (anoHasta+1); i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            diasTotales = diasTotales + 366;
                        }
                        else
                        {
                            diasTotales = diasTotales + 365;
                        }
                    }
                    else
                    {
                        diasTotales = diasTotales + 366;
                    }
                }
                else
                {
                    diasTotales = diasTotales + 365;
                }
            }

            Console.WriteLine(diaHasta);
            Console.ReadKey();
        }
    }
}
