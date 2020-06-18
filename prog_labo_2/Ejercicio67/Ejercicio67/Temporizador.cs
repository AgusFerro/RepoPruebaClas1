using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio67
{
    public sealed class Temporizador
    {
        public delegate void encargadoTiempo();
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                return !(this.hilo is null) && this.hilo.IsAlive;
            }
            set
            {
                if(this.Activo && value == false)
                {
                    this.hilo.Abort();
                }
                else if(!(this.Activo) && value == true)
                {
                    this.hilo = new Thread(this.Corriendo);
                    this.hilo.Start();
                }
            }
        }
        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        private void Corriendo()
        {
            while(true)
            {
                Thread.Sleep(this.intervalo);
                this.EventoTiempo.Invoke();
            }
        }

        public event encargadoTiempo EventoTiempo;
    }
}
