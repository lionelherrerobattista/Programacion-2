using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {

        private int dni;
        private string nombre;
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
        }
        /// <summary>
        /// Lectura/Escritura para el nombre del jugador
        /// </summary>
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

        /// <summary>
        /// Lectura/Escritura para el atributo dni
        /// </summary>
        public int DNI
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

        /// <summary>
        /// Constructor por defecto del jugador, inicializa
        /// los datos estadísticos en 0
        /// </summary>
        private Jugador()
        {
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



            datos = string.Format("{0,10} {1,10} {2,10} {3,10} {4,10: #.00}", this.DNI,
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

            if (j1.dni != j2.dni)
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

