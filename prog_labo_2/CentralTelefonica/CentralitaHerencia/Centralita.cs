using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        } 

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;

            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(item is Local)
                        {
                            total += ((Local)item).CostoLlamada;
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
                            total += ((Local)item).CostoLlamada;
                        }
                        break;
                }
            }

            return total;
        }

        public new string ToString()
        {
            return Mostrar();
        }

        private string Mostrar()
        {
            StringBuilder cadenaCentralita = new StringBuilder();

            cadenaCentralita.AppendLine($"Razon Social: {this.razonSocial}");
            //cadenaCentralita.AppendLine($"Ganancias por Local: {this.GananciasPorLocal}");
            //cadenaCentralita.AppendLine($"Ganancias por Provincial: {this.GananciasPorProvincial}");
            //cadenaCentralita.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            
            foreach(Llamada item in this.Llamadas)
            {
                cadenaCentralita.AppendLine(item.ToString());   
            }

            return cadenaCentralita.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool b = false;
            foreach(Llamada item in c.Llamadas)
            {
                if(llamada == item)
                { 
                    b = true;
                    break;
                }
            }

            return b;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if((c == nuevaLlamada) == false)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("No puede agregar una llamada que ya esta en la lista", "Centralita", "public static Centralita operator +");
            }

            return c;
        }
        #endregion
    }
}
