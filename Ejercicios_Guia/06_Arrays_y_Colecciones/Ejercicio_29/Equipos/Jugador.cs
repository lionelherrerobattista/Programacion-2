using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        /// <summary>
        /// Calcula el promedio de goles del jugador y lo devuelve
        /// </summary>
        /// <returns>Promedio de goles del jugador</returns>
        public float GetPromedioGoles()
        {
            float promedioGoles;

            promedioGoles = (float)totalGoles / partidosJugados;

            return promedioGoles;
        }

        /// <summary>
        /// Constructor por defecto del jugador, inicializa
        /// los datos estadísticos en 0
        /// </summary>
        private Jugador()
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;

        }

        /// <summary>
        /// Constructor de la clase Jugador
        /// Recibe datos personales
        /// </summary>
        /// <param name="dni">Dni del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;

        }

        /// <summary>
        /// Constructor de la clase jugador
        /// Recibe dni, nombre y datos estadísticos
        /// </summary>
        /// <param name="dni">DNI del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        /// <param name="totalGoles">Total de goles que hizo el jugador</param>
        /// <param name="totalPartidos">Total de partidos que jugó</param>
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
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

            this.promedioGoles = GetPromedioGoles();

            datos = string.Format("{0} {1} {2} {3} {4: #.00}", this.dni,
                this.nombre, this.partidosJugados, this.totalGoles, this.promedioGoles);

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

            if(j1.dni != j2.dni)
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
