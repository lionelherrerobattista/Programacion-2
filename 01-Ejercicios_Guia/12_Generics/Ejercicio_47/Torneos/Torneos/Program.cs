using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio_47;
using System.Threading;

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

            EquipoBasquet equipoCuatro;
            EquipoBasquet equipoCinco;
            EquipoBasquet equipoSeis;



            //Creo torneos
            torneoFutbol = new Torneo<EquipoFutbol>("Superliga de fútbol");
            torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            //Creo equipos fútbol
            equipoUno = new EquipoFutbol("Boca", DateTime.Now.Date);
            equipoDos = new EquipoFutbol("River", DateTime.Now.Date);
            equipoTres = new EquipoFutbol("Tigre", DateTime.Now.Date);

            //Creo equipos básquet
            equipoCuatro = new EquipoBasquet("Bulls", DateTime.Now.Date);
            equipoCinco = new EquipoBasquet("Lakers", DateTime.Now.Date);
            equipoSeis = new EquipoBasquet("Raptors", DateTime.Now.Date);

            //Agrego equipos a torneo de fútbol
            Console.WriteLine("--------------Equipos Fútbol---------------");
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


            if (torneoFutbol + equipoCuatro)//no debería agregar
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }


            Console.WriteLine("--------------Equipos Básquet--------------");

            //Agrego equipos a torneo de básquet

            if (torneoBasquet + equipoCuatro)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoBasquet + equipoCuatro)//no debería agregar
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoBasquet + equipoCinco)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (torneoBasquet + equipoSeis)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            if(torneoFutbol + equipoCinco)
            {
                Console.WriteLine("Equipo agregado.");
            }
            else
            {
                Console.WriteLine("Error");
            }


            //Muestro torneos
            Console.WriteLine("");

            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine("");

            Console.WriteLine(torneoBasquet.Mostrar());

            //Simulo partidos
            Console.WriteLine("--------------Partidos--------------");
            Console.WriteLine("Futbol:");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(200);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(200);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Thread.Sleep(200);
            Console.WriteLine("");

            Console.WriteLine("Básquet:");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Thread.Sleep(200);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Thread.Sleep(200);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
