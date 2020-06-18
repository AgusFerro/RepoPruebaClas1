using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using System.Data;
using System.Data.SqlClient;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        private static SqlConnection sqlConnection = new SqlConnection("Data Source = localhost; Database = centralita; Trusted_Connection=True;");
        private static SqlCommand sqlCommand;

        public static bool Guardar(Local llamada)
        {
            bool success;
            sqlCommand = new SqlCommand("INSERT INTO Llamadas VALUES(@duracion,@origen,@destino,@costo,0)",sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("duracion",llamada.duracion));
            sqlCommand.Parameters.Add(new SqlParameter("origen", llamada.NroOrigen));
            sqlCommand.Parameters.Add(new SqlParameter("destino", llamada.nroDestino));
            sqlCommand.Parameters.Add(new SqlParameter("costo", llamada.CostoLlamada));

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo guardar la llamada");
                success = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return success;
        }

        public static Local Leer(int id)
        {
            Local local = null;
            SqlDataReader llamadaTabla;

            sqlCommand = new SqlCommand("SELECT * FROM Llamadas WHERE tipo = 0 AND id = @id", sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("id", id));

            try
            {
                sqlConnection.Open();
                llamadaTabla = sqlCommand.ExecuteReader();
                local = new Local(llamadaTabla["origen"].ToString(),float.Parse(llamadaTabla["duracion"].ToString()),llamadaTabla["destino"].ToString(),float.Parse(llamadaTabla["costo"].ToString()));
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo leer la llamada");
            }
            finally
            {
                sqlConnection.Close();
            }

            return local;
        }
    }
}
