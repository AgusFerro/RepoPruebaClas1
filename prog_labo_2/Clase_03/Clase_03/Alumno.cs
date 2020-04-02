using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random random = new Random();
                this.notaFinal = random.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            if (this.notaFinal != -1)
            {
                return "El nombre es: " + this.nombre + "\n" + "El apellido es: " + this.apellido + "\n"
                        + "La primer nota es: " + this.nota1 + "\n" + "La segunda nota es: " + this.nota2 + "\n"
                        + "La nota final es: " + this.notaFinal;
            }
            else
            {
                return "El nombre es: " + this.nombre + "\n" + "El apellido es: " + this.apellido + "\n"
                        + "La primer nota es: " + this.nota1 + "\n" + "La segunda nota es: " + this.nota2 + "\n"
                        + "Alumno desaprobado";
            }
        }

    }
}
