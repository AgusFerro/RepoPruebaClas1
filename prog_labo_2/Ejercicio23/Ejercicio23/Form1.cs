using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monedas;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Candado_Click(object sender, EventArgs e)
        {
            if (textCotizacionEuro.Enabled == true)
            {
                textCotizacionEuro.Enabled = false;
                textCotizacionDolar.Enabled = false;
                textCotizacionPesos.Enabled = false;
            }
            else
            {
                textCotizacionEuro.Enabled = true;
                textCotizacionDolar.Enabled = true;
                textCotizacionPesos.Enabled = true;
            }
        }

        private void textCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(textCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                textCotizacionEuro.Focus();
            }
        }

        private void textCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(textCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                textCotizacionDolar.Focus();
            }
        }

        private void textCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(textCotizacionPesos.Text, out aux))
            {
                Monedas.Pesos.SetCotizacion(aux);
            }
            else
            {
                textCotizacionPesos.Focus();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(textEuro.Text,out aux);

            Euro e1 = new Euro(aux);
            Dolar d1 = (Dolar)e1;
            Pesos p1 = (Pesos)e1;

            textEuroAEuro.Text = aux.ToString();

            textEuroADolar.Text = d1.GetCantidad().ToString();
        }
    }
}
