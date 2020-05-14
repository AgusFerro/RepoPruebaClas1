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
            richTextBox1.Text = this.centralita.
        }
    }
}
