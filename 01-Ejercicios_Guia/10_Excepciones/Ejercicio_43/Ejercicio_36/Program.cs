using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio_36;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 primerAuto = new AutoF1(23, "Ferrari", 200);
            AutoF1 segundoAuto = new AutoF1(23, "Ferrari", 200);
            MotoCross primeraMoto = new MotoCross(23, "McClaren", 88);
            Competencia campeonatoF1 = new Competencia(60, 30, Competencia.TipoCompetencia.F1);

            Console.Title = "Ejercicio_30";

            //Muestro el auto creado
            Console.WriteLine("Antes de entrar en competencia:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "Número", "Escudería", "Vueltas", "Combustible");
            Console.WriteLine(primerAuto.MostrarDatos());

            //Cargo un auto a la lista
            if (campeonatoF1 + primerAuto)
            {
                Console.WriteLine("Cargó");

            }
            else
            {
                Console.WriteLine("Error");
            }

            //No se tienen que cargar
            try
            {

                if (campeonatoF1 + primeraMoto)
                {
                    Console.WriteLine("Cargó");

                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("\n{0}\n", e.ToString()));
            }

            /*
            if (campeonatoF1 + segundoAuto)
            {
                Console.WriteLine("Cargó");

            }
            else
            {
                Console.WriteLine("Error");
            }*/

            //Compruebo que esté guardado
            Console.WriteLine("\nDespués de entrar en competencia:");
            if (primerAuto.EnCompetencia == true)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "Número", "Escudería", "Vueltas", "Combustible");
                Console.WriteLine(primerAuto.MostrarDatos());
            }


            Console.ReadKey();
        }
    }
}
