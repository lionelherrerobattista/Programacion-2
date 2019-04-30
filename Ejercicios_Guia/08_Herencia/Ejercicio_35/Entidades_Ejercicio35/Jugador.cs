using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {

        private int partidosJugados;
        private int totalGoles;

        /// <summary>
        /// Devuelve un int con la cantidad de partidos jugados
        /// </summary>
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        /// <summary>
        /// Devuelve un float con el promedio de goles
        /// </summary>
        public float PromedioGoles
        {
            get
            {
                float promedioGoles;

                promedioGoles = (float)totalGoles / partidosJugados;

                return promedioGoles;
            }
      
        }

        /// <summary>
        /// Devuelve un int con la cantidad total de goles
        /// </summary>
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                totalGoles = value;
            }
        }


        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }

        /// <summary>
        /// Constructor de la clase jugador
        /// Recibe dni, nombre y datos estadísticos
        /// </summary>
        /// <param name="dni">DNI del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        /// <param name="totalGoles">Total de goles que hizo el jugador</param>
        /// <param name="totalPartidos">Total de partidos que jugó</param>
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        /// <summary>
        /// Devuelve un string con los datos estadísticos del jugador
        /// </summary>
        /// <returns>String con los datos estadísticos</returns>
        public string MostrarDatos()
        {
            string datos;



            datos = string.Format("{0,10} {1,10} {2,10} {3,10} {4,10: #.00}", this.Dni,
                this.Nombre, this.PartidosJugados, this.TotalGoles, this.PromedioGoles);

            return datos;
        }

        /// <summary>
        /// Sobrecarga el operador != para comparar jugadores por DNI
        /// </summary>
        /// <param name="j1">Primer jugador a comparar</param>
        /// <param name="j2">Segundo jugador a comparar</param>
        /// <returns>True si los juga</returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            bool sonDistintos = false;

            if (j1.Dni != j2.Dni)
            {
                sonDistintos = true;
            }

            return sonDistintos;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return !(j1 != j2);
        }


    }
}

