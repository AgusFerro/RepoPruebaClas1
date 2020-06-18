using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using EntidadesDAO;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            //c.Llamadas.Add(l1);
            //Console.WriteLine(c.Mostrar());
            //c.Llamadas.Add(l2);
            //Console.WriteLine(c.Mostrar());
            //c.Llamadas.Add(l3);
            //Console.WriteLine(c.Mostrar());
            //c.Llamadas.Add(l4);
            //Console.WriteLine(c.Mostrar());

            c = c + l1;
            c = c + l2;
            c = c + l3;

            try { c = c + l4; }

            catch (CentralitaException e)
            {
                Console.WriteLine(e.Message);
            }

            /*
            //Agrego las llamadas de Centralita a la DB
            foreach(Llamada llamada in c.Llamadas)
            {
                if(llamada is Local)
                {
                    LocalDAO.Guardar((Local)llamada);
                }
                else if (llamada is Provincial)
                {
                    ProvincialDAO.Guardar((Provincial)llamada);
                }
            }*/

            try
            {
                c += ProvincialDAO.Leer(1);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            /*
            //Agrego la llamada a un archivo xml
            l2.RutaDeArchivo = @"C:\Users\agusf\Source\Repos\CentralTelefonica\Provincial.xml";
            l2.Guardar();

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.WriteLine(c.Leer());
            */

            Console.ReadKey();

        }
    }
}
