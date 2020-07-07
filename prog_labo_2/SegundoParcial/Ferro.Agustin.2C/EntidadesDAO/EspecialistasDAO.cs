using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace EntidadesDAO
{
    public static class EspecialistasDAO
    {
        #region Atributos
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataReader sqlDataReader;
        #endregion
        #region Metodos
        static EspecialistasDAO()
        {
            sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
        }
        /// <summary>
        /// Comparo un objeto Especialista con uno de la base
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool Comparar(Especialista e)
        {
            bool success = false;
            sqlCommand = new SqlCommand("SELECT * FROM Especialistas WHERE nombre = @nombre AND apellido = @apellido AND especialidad = @especialidad",sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("nombre",e.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("apellido", e.Apellido));
            sqlCommand.Parameters.Add(new SqlParameter("especialidad", e.Especialidad.ToString()));
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //creo el objeto Especialista y lo comparo
                    Especialista aux = new Especialista(int.Parse(sqlDataReader["idEspecialista"].ToString()), sqlDataReader["apellido"].ToString(), sqlDataReader["nombre"].ToString()
                        , int.Parse(sqlDataReader["edad"].ToString()), sqlDataReader["sexo"].ToString(), sqlDataReader["direccion"].ToString(), (Especialista.EEspecialidad)Enum.Parse(typeof(Especialista.EEspecialidad),sqlDataReader["especialidad"].ToString()));

                    if (e == aux)
                    {
                        success = true;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                //log de errores
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: EspecialistaDAO.Comparar()");
                success = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return success;
        }

        /// <summary>
        /// Devuelve un objeto Especialista con el numero de Id enviado por parametro
        /// </summary>
        /// <param name="idEspecialista">int id</param>
        /// <returns>Especialista</returns>
        public static Especialista TraerPorId(int idEspecialista)
        {
            Especialista aux = null;
            sqlCommand = new SqlCommand("SELECT * FROM Especialistas WHERE idEspecialista = @idEspecialista", sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("idEspecialista", idEspecialista));

            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //creo el objeto Especialista
                    aux = new Especialista(int.Parse(sqlDataReader["idEspecialista"].ToString()), sqlDataReader["apellido"].ToString(), sqlDataReader["nombre"].ToString()
                        , int.Parse(sqlDataReader["edad"].ToString()), sqlDataReader["sexo"].ToString(), sqlDataReader["direccion"].ToString(), (Especialista.EEspecialidad)Enum.Parse(typeof(Especialista.EEspecialidad), sqlDataReader["especialidad"].ToString()));
                }
            }
            catch (Exception ex)
            {
                //log de errores
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: EspecialistaDAO.TraerPorId()");
            }
            finally
            {
                sqlConnection.Close();
            }
            return aux;
        }
        #endregion
    }
}
