using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimerEjercicioSQL
{
    public partial class Form1 : Form
    {
        SqlConnection miConexion;  //PUENTE
        SqlCommand miComando;      //CONSULTA
        SqlDataReader objetoTabla;  //OBJETO QUE ME TRAE LA INFO
        DataTable miTabla;          // TRANSFORMA EL OBJETO EN FORMATO TABLA
        public Form1()
        {
            miConexion = new SqlConnection("Data Source = localhost; Database = utnfra; Trusted_Connection=True;");
            miComando = new SqlCommand();
            miTabla = new DataTable();


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            //string auxLegajo;
            //string auxNombre;
            //string auxApellido;
            //string auxCurso;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                miTabla.Clear();

                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos WHERE curso = @cursoAFiltrar";
                miComando.Parameters.Clear();
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(textBox1.Text)) );

                miConexion.Open(); //ABRIMOS LA CONEXION

                objetoTabla = miComando.ExecuteReader();  //EN ESTE MOMENTO ES CUANDO VIAJA LA CONSULTA

                miTabla.Load(objetoTabla);

                dataGridView1.DataSource = miTabla;
                //while (objetoTabla.Read())
                //{
                //    auxLegajo = objetoTabla["legajo"].ToString();
                //    auxNombre = objetoTabla["nombre"].ToString();
                //    auxApellido = objetoTabla["apellido"].ToString();
                //    auxCurso = objetoTabla["curso"].ToString();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base", "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                miConexion.Close();
            }
        }
    }
}
