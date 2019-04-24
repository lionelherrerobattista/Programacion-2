using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
      
        }

        public Equipo(short cantidad, string nombre)
        {
            jugadores = new List<Jugador>();
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool agregoJugador = false;

            if(e.jugadores.Count < e.cantidadDeJugadores && e.jugadores.Contains(j) == false)
            {
                e.jugadores.Add(j);
                agregoJugador = true;

            }

            return agregoJugador;


        }

    }
}
