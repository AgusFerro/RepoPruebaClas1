using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> lista;

        public List<IAcciones> Lista
        {
            get
            {
                return this.lista;
            }
        }
        public Cartuchera1()
        {
            this.lista = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            bool success = false;
            int flag = 0;

            foreach(Boligrafo item in this.Lista)
            {
                if((item.UnidadesDeEscritura - 1) < 0)
                {
                    item.UnidadesDeEscritura = 10;
                    flag++;
                }
                else
                {
                    item.UnidadesDeEscritura -= 1;
                }
            }

            if(flag == 0)
            {
                success = true;
            }

            return success;
        }
    }
}
