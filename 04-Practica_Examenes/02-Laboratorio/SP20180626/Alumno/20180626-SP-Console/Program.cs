using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Threading;

namespace _20180626_SP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo t = new Torneo("Rusia 2018");

            Console.Title = "Copa Mundial Rusia 2018";

            Grupo grupoA = new Grupo(Letras.A, Torneo.MAX_EQUIPOS_GRUPO);
            grupoA = grupoA.Leer();
            t.Grupos.Add(grupoA);

            Grupo grupoB = new Grupo(Letras.B, Torneo.MAX_EQUIPOS_GRUPO);
            grupoB = grupoB.Leer();
            t.Grupos.Add(grupoB);

            Grupo grupoC = new Grupo(Letras.C, Torneo.MAX_EQUIPOS_GRUPO);
            grupoC = grupoC.Leer();
            t.Grupos.Add(grupoC);

            Grupo grupoD = new Grupo(Letras.D, Torneo.MAX_EQUIPOS_GRUPO);
            grupoD = grupoD.Leer();
            t.Grupos.Add(grupoD);

            t.eventoResultados += Program.ImprimirResultados;


            // Agregar Thread
            Thread hilo = new Thread(t.SimularGrupos);
            hilo.Start();
            // **************

            if(t.Guardar())
            {
                Console.WriteLine("Presione una tecla para continuar...\n");
                Console.ReadKey();
                Console.Clear();
            }

            Torneo t2 = new Torneo("Qatar 2022");

            t.Leer();

            // Agregar Thread
            Thread hilo2 = new Thread(t.SimularGrupos);
            hilo2.Start();
            // **************



            Console.ReadKey();
        }

        public static void ImprimirResultados(Grupo g)
        {
            string resultados;

            resultados = g.MostrarTabla();

            Console.WriteLine(resultados);

        }


    }
}
