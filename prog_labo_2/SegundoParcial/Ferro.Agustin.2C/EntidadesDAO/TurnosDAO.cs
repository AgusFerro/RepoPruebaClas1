using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Runtime.CompilerServices;
using Archivos;

namespace EntidadesDAO
{
    public static class TurnosDAO
    {
        #region Atributos
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        #endregion
        #region Metodos
        static TurnosDAO()
        {
            sqlConnection = new SqlConnection("Data Source = localhost; Database = ClinicaUtn; Trusted_Connection = True; ");
        }
        /// <summary>
        /// Metodo estatico que inserta un Turno en la base
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public static bool Insertar(Turnos turno)
        {
            bool success = false;
            sqlCommand = new SqlCommand("INSERT INTO Turnos VALUES (@idPaciente,@idEspecialista,@observacionesTurno,@fecha)",sqlConnection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("idPaciente",turno.IdPaciente));
            sqlCommand.Parameters.Add(new SqlParameter("idEspecialista", turno.IdEspecialista));
            sqlCommand.Parameters.Add(new SqlParameter("observacionesTurno", turno.ObservacionTurno));
            sqlCommand.Parameters.Add(new SqlParameter("fecha", turno.FechaTurno));

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (Exception e)
            {
                Texto error = new Texto();
                error.Guardar($"{e.Message} - Metodo: TurnosDAO.Insertar()");
                success = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return success;
        }
        #endregion
    }
}
