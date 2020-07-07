using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Archivos;

namespace EntidadesDAO
{
    public static class PacientesDAO
    {
        #region Atributos
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataReader sqlDataReader;
        #endregion
        #region Metodos
        static PacientesDAO()
        {
            sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
        }

        /// <summary>
        /// Compara un objeto Paciente con uno de la tabla
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Comparar(Paciente p)
        {
            bool success = false;
            sqlCommand = new SqlCommand("SELECT * FROM Pacientes WHERE nombre = @nombre AND apellido = @apellido AND direccion = @direccion", sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("nombre", p.Nombre));
            sqlCommand.Parameters.Add(new SqlParameter("apellido", p.Apellido));
            sqlCommand.Parameters.Add(new SqlParameter("direccion", p.Direccion));
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //creo el objeto Paciente y lo comparo
                    Paciente aux = new Paciente(int.Parse(sqlDataReader["idPaciente"].ToString()), sqlDataReader["apellido"].ToString(), sqlDataReader["nombre"].ToString()
                        , int.Parse(sqlDataReader["edad"].ToString()), sqlDataReader["sexo"].ToString(), sqlDataReader["direccion"].ToString(), (Paciente.EObraSocial)Enum.Parse(typeof(Paciente.EObraSocial), sqlDataReader["obraSocial"].ToString()));

                    if (p == aux)
                    {
                        success = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //log de errores
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: PacientesDAO.Comparar()");
                success = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return success;
        }

        /// <summary>
        /// Verifico si existe el Paciente con el Id que recibo por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool VerificarPorId(int id)
        {
            bool success = false;
            sqlCommand = new SqlCommand("SELECT * FROM Pacientes WHERE idPaciente = @id", sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("id", id));
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //Si puedo crear el objeto Paciente, es porque existe, sino no
                    Paciente aux = new Paciente(int.Parse(sqlDataReader["idPaciente"].ToString()), sqlDataReader["apellido"].ToString(), sqlDataReader["nombre"].ToString()
                        , int.Parse(sqlDataReader["edad"].ToString()), sqlDataReader["sexo"].ToString(), sqlDataReader["direccion"].ToString(), (Paciente.EObraSocial)Enum.Parse(typeof(Paciente.EObraSocial), sqlDataReader["obraSocial"].ToString()));

                    if (aux is Persona)
                    {
                        success = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //log de errores
                Texto error = new Texto();
                error.Guardar($"{ex.Message} - Metodo: PacientesDAO.CompararPorId()");
                success = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return success;
        }

        /// <summary>
        /// Devuelvo un Paciente con el Id recibido por parametro
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <returns></returns>
        public static Paciente TraerPorId(int idPaciente)
        {
            Paciente aux = null;
            sqlCommand = new SqlCommand("SELECT * FROM Pacientes WHERE idPaciente = @idPaciente", sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("idPaciente", idPaciente));

            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //creo el objeto Especialista
                    aux = new Paciente(int.Parse(sqlDataReader["idPaciente"].ToString()), sqlDataReader["apellido"].ToString(), sqlDataReader["nombre"].ToString()
                        , int.Parse(sqlDataReader["edad"].ToString()), sqlDataReader["sexo"].ToString(), sqlDataReader["direccion"].ToString(), (Paciente.EObraSocial)Enum.Parse(typeof(Paciente.EObraSocial), sqlDataReader["obraSocial"].ToString()));
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
