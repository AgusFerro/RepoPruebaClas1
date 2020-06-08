using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.DataSource = PersonaDAO.Leer();
                listBox1.DisplayMember = "ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PersonaDAO.Guardar(new Persona(txtNombre.Text, txtApellido.Text)) == false)
            {
                MessageBox.Show("Error", "No se pudo agregar a la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = ((Persona)listBox1.SelectedItem).Nombre;
            txtApellido.Text = ((Persona)listBox1.SelectedItem).Apellido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (PersonaDAO.Modificar(((Persona)listBox1.SelectedItem).ID, txtNombre.Text, txtApellido.Text) == false)
            {
                MessageBox.Show("Error", "No se pudo modificar en la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (PersonaDAO.Borrar(((Persona)listBox1.SelectedItem).ID) == false)
            {
                MessageBox.Show("Error", "No se pudo borrar en la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
