using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        #endregion

        #region Metodos
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;

            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(item is Local)
                        {
                            total += ((Local)item).Costo;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        else if(item is Local)
                        {
                            total += ((Local)item).Costo;
                        }
                        break;
                }
            }

            return total;
        }

        public string Mostrar()
        {
            StringBuilder cadenaCentralita = new StringBuilder();

            cadenaCentralita.AppendLine($"Razon Social: {this.razonSocial}");
            cadenaCentralita.AppendLine($"Ganancias por Local: {this.GananciasPorLocal}");
            cadenaCentralita.AppendLine($"Ganancias por Provincial: {this.GananciasPorProvincial}");
            cadenaCentralita.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            foreach(Llamada item in this.Llamadas)
            {
                if(item is Local)
                {
                    Console.WriteLine(((Local)item).Mostrar());
                }
                else if(item is Provincial)
                {
                    Console.WriteLine(((Provincial)item).Mostrar());
                }
            }

            return cadenaCentralita.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
