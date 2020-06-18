using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Ejercicio67;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        delegate void Delegado(object d);
        private Thread t;
        Temporizador temp;
        public void TemporizadorHandler()
        {
            ThreadStart pts = new ThreadStart(CambiarLabel);
            this.t = new Thread(pts);
            this.t.Start();
        }

        public Form1()
        {
            InitializeComponent();
            temp = new Temporizador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp.EventoTiempo += TemporizadorHandler;
            temp.Intervalo = 200;
            temp.Activo = true;
        }
        private void CambiarLabel()
        {
            do
            {
                this.AsignarHora(DateTime.Now.ToString());
                Thread.Sleep(200);
            } while (true);

        }

        private void AsignarHora(object o)
        {   

            if (this.lblHora.InvokeRequired)
            {
                Delegado d = new Delegado(this.AsignarHora);
                object[] obj = new object[] { o };
                this.Invoke(d, obj);
            }
            else
            {
                this.lblHora.Text = o.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
            if (temp.Activo)
            {
                temp.Activo = false;
            }
        }
    }
}
