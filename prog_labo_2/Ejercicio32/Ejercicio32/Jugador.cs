using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;



        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados >= 0)
                    return ((float)this.totalGoles / (float)this.partidosJugados);
                else
                    return 0;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
        }
        public Jugador(int documento, string nombre)
        {
            this.dni = documento;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this (dni,nombre)
        { 
            this.totalGoles=totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos ()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"DNI del jugador: {this.dni.ToString()}");
            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Goles: {this.totalGoles.ToString()}");
            retorno.AppendLine($"Partidos jugados: {this.partidosJugados.ToString()}");
            retorno.AppendLine($"Promedio goles: {this.promedioGoles.ToString()}");

            return retorno.ToString();
        }

        public static bool operator != (Jugador j1,Jugador j2)
        {
            if (j1.dni != j2.dni)
                return true;
            else
                return false;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
                return true;
            else
                return false;
        }
    }
}