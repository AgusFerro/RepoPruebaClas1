using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cartuchera2
    {
        private List<Boligrafo> listaBoligrafo;
        private List<Lapiz> listaLapiz;

        public List<Boligrafo> ListaBoligrafo
        {
            get
            {
                return this.listaBoligrafo;
            }
        }
        public List<Lapiz> ListaLapiz
        {
            get
            {
                return this.listaLapiz;
            }
        }
        public Cartuchera2()
        {
            this.listaBoligrafo = new List<Boligrafo>();
            this.listaLapiz = new List<Lapiz>();
        }

        public bool ProbarElementos()
        {
            bool success = false;
            int flag1 = 0, flag2 = 0;

            foreach (Lapiz item in this.ListaLapiz)
            {
                if ((((IAcciones)item).UnidadesDeEscritura - 1) < 0)
                {
                    ((IAcciones)item).UnidadesDeEscritura = 10;
                    flag1++;
                }
                else
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                }
            }

            foreach (Boligrafo item in this.ListaBoligrafo)
            {
                if ((item.UnidadesDeEscritura - 1) < 0)
                {
                    item.UnidadesDeEscritura = 10;
                    flag2++;
                }
                else
                {
                    item.UnidadesDeEscritura -= 1;
                }
            }

            if (flag1 == 0 && flag2 == 0)
            {
                success = true;
            }

            return success;
        }
    }
}
