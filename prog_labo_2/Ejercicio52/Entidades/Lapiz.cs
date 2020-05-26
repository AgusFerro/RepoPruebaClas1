using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }

            set => throw new NotImplementedException();
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int t = texto.Length;
            double unidades = texto.Length * 0.1;

            if (unidades < this.tamanioMina)
            {
                this.tamanioMina -= (float)unidades;
                return new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }

            return null;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
