using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipo;

        public Llamada.TipoLlamada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.centralita.ToString());
            foreach(Llamada item in this.centralita.Llamadas)
            { 
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Todas:
                        sb.AppendLine(item.ToString());
                        break;
                    case Llamada.TipoLlamada.Local:
                        if(item is Local)
                        {
                            sb.AppendLine(item.ToString());
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if(item is Provincial)
                        {
                            sb.AppendLine(item.ToString());
                        }
                        break;
                }
            }
            if (tipo == Llamada.TipoLlamada.Local)
            {
                sb.AppendLine($"Facturacion Local: {this.centralita.GananciasPorLocal}");
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                sb.AppendLine($"Facturacion Provincial: {this.centralita.GananciasPorProvincial}");
            }
            else
            {
                sb.AppendLine($"Facturacion Total: {this.centralita.GananciasPorTotal}");
            }
                
            richTextBox1.Text = sb.ToString();
        }
    }
}
