using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string encabezado;

            Equipo equipoNuevo = new Equipo(2, "Boca");
            Jugador jugadorUno = new Jugador(34224440, "Juan", 20, 15);
            Jugador jugadorDos = new Jugador(34342343, "Pedro", 2, 30);
            Jugador jugadorTres = new Jugador(43244356, "Lucas", 0, 12);

            encabezado = String.Format("    {0,-10} {1,-10} {2,-10}   {3,-10} {4,10}",
                "DNI", "NOMBRE", "PARTIDOS", "GOLES", "PROMEDIO DE GOL");
            Console.WriteLine(encabezado);
            Console.WriteLine(jugadorUno.MostrarDatos());

            if (equipoNuevo + jugadorUno)
            {
                Console.WriteLine("Agrego jugador");
            }
            if (equipoNuevo + jugadorDos)
            {
                Console.WriteLine("Agrego jugador");
            }

            if (equipoNuevo + jugadorTres)
            {
                Console.WriteLine("Agrego jugador");
            }
            else
            {
                Console.WriteLine("No hay espacio");
            }


            Console.ReadKey();
        }
    }
}
