using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        private static SqlConnection miConexion = new SqlConnection("Data Source = localhost; Database = workspace; Trusted_Connection=True;");
        //private static SqlCommand miComando = new SqlCommand();
        private static SqlCommand miComando;

        public static bool Guardar(Persona persona)
        {
            bool success;

            //miComando.Connection = miConexion;
            //miComando.CommandType = CommandType.Text;
            //miComando.CommandText = "INSERT INTO Persona VALUES (@nombre, @apellido)";
            miComando = new SqlCommand("INSERT INTO Persona VALUES (@nombre, @apellido)",miConexion);
            miComando.Parameters.Clear();
            miComando.Parameters.Add(new SqlParameter("nombre",persona.Nombre));
            miComando.Parameters.Add(new SqlParameter("apellido", persona.Apellido));

            try
            {
                miConexion.Open();
                miComando.ExecuteNonQuery();
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            finally 
            {
                miConexion.Close();
            }
            return success;
        }
        public static List<Persona> Leer()
        //public static DataTable Leer()
        {
            SqlDataReader personaTabla;
            List<Persona> listaPersonas = new List<Persona>();
            DataTable tabla = new DataTable();

            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "SELECT * FROM Persona";

            try
            {
                miConexion.Open();
                personaTabla = miComando.ExecuteReader();
                //tabla.Load(personaTabla);
                while (personaTabla.Read() == true)
                {
                    listaPersonas.Add(new Persona(Int32.Parse(personaTabla["id"].ToString()), personaTabla["nombre"].ToString(), personaTabla["apellido"].ToString()));
                }

            }
            catch (Exception)
            {
                throw new Exception("Error al leer la base");
            }
            finally
            {
                miConexion.Close();
            }
            return listaPersonas;
            //return tabla;
        }
        public static Persona LeerPorID(int id)
        {
            SqlDataReader personaTabla;
            Persona persona;

            miComando = new SqlCommand("SELECT * FROM Persona WHERE id = @id", miConexion);
            miComando.Parameters.Clear();
            miComando.Parameters.Add(new SqlParameter("id", id));

            try
            {
                miConexion.Open();
                personaTabla = miComando.ExecuteReader();
                persona = new Persona(Int32.Parse(personaTabla["id"].ToString()), personaTabla["nombre"].ToString(), personaTabla["apellido"].ToString());

            }
            catch (Exception)
            {
                throw new Exception("Error al leer la base");
            }
            finally
            {
                miConexion.Close();
            }
            return persona;
        }
        public static bool Modificar(int id,string nombre, string apellido)
        {
            bool success;

            miComando = new SqlCommand("UPDATE Persona SET nombre = @nombre, apellido = @apellido WHERE id = @id", miConexion);
            miComando.Parameters.Clear();
            miComando.Parameters.Add(new SqlParameter("nombre", nombre));
            miComando.Parameters.Add(new SqlParameter("apellido", apellido));
            miComando.Parameters.Add(new SqlParameter("id", id));

            try
            {
                miConexion.Open();
                miComando.ExecuteNonQuery();
                success = true;

            }
            catch (Exception)
            {
                success = false;
            }
            finally
            {
                miConexion.Close();
            }
            return success;

        }
        public static bool Borrar(int id)
        {
            bool success;

            miComando = new SqlCommand("DELETE Persona WHERE id = @id", miConexion);
            miComando.Parameters.Clear();
            miComando.Parameters.Add(new SqlParameter("id", id));

            try
            {
                miConexion.Open();
                miComando.ExecuteNonQuery();
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            finally
            {
                miConexion.Close();
            }
            return success;
        }
    }
}
