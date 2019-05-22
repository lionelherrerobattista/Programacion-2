using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio_47;

namespace Torneos
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol;
            Torneo<EquipoBasquet> torneoBasquet;
            EquipoFutbol equipoUno;
            EquipoFutbol equipoDos;
            EquipoFutbol equipoTres;

            //Creo torneos
            torneoFutbol = new Torneo<EquipoFutbol>("Superliga de fútbol");

            //Creo equipos
            equipoUno = new EquipoFutbol("Boca", DateTime.Now.Date);
            equipoDos = new EquipoFutbol("River", DateTime.Now.Date);
            equipoTres = new EquipoFutbol("Tigre", DateTime.Now.Date);

            if (torneoFutbol + equipoUno)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoFutbol + equipoUno)//no debería agregar
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoFutbol + equipoDos)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoFutbol + equipoTres)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("");

            Console.WriteLine(torneoFutbol.Mostrar());

            Console.ReadKey();
        }
    }
}
