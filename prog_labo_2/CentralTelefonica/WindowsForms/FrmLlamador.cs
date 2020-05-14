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
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.StartsWith("#") == true)
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }
        private void txtNroDestino_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "0";
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "*";
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();

            if (txtNroDestino.Text.StartsWith("#") == true)
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

                this.centralita += new Provincial(txtNroOrigen.Text,franjas,r1.Next(1,50),txtNroDestino.Text);
            }
            else
            {
                double costo = r1.Next(0, 5) + r1.NextDouble();
                this.centralita += new Local(txtNroOrigen.Text, r1.Next(1, 50), txtNroDestino.Text,(float)costo);
            }
        }
    }
}
