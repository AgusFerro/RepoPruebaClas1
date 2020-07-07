using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// Metodo de extencion de la clase Especialista para crear una observacion del turno
        /// segun su Especialidad
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string ObservacionDelTurno(this Especialista e)
        {
            string str = "";
            switch (e.Especialidad)
            {
                case Especialista.EEspecialidad.ClinicaGeneral:
                    str = "Le paciente esta en buen estado";
                    break;
                case Especialista.EEspecialidad.Dermatologia:
                    str = "Le paciente presenta muchos granos";
                    break;
                case Especialista.EEspecialidad.Ginecologia:
                    str = "Le paciente vino a pedir anticonceptivos";
                    break;
                case Especialista.EEspecialidad.Obtetricia:
                    str = "Le paciente vino a realizarce una ecografia";
                    break;
                case Especialista.EEspecialidad.Oftalmologia:
                    str = "Le paciente no ve nada";
                    break;
                case Especialista.EEspecialidad.Otorrinolaringologia:
                    str = "Le paciente vino por una otitis";
                    break;
                case Especialista.EEspecialidad.Pediatria:
                    str = "Le paciente vino a consultar por un cuadro de fiebre";
                    break;
                case Especialista.EEspecialidad.Psicologia:
                    str = "Le paciente no esta bien del bocho";
                    break;
                default:
                    str = "Inconcluso";
                    break;
            }

            return str;
        }
    }
}
