using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campeonato;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 primerAuto = new AutoF1(23, "Ferrari");
            Competencia campeonatoF1 = new Competencia(60, 30);

            Console.Title = "Ejercicio_30";

            //Muestro el auto creado
            Console.WriteLine("Antes de entrar en competencia:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "Número", "Escudería", "Vueltas", "Combustible");
            Console.WriteLine(primerAuto.MostrarDatos());

            //Cargo un auto a la lista
            if(campeonatoF1 + primerAuto)
            {
                Console.WriteLine("Cargó");
                
            }
            else
            {
                Console.WriteLine("Error");
            }

            //Compruebo que esté guardado
            Console.WriteLine("\nDespués de entrar en competencia:");
            if (primerAuto.GetEnCompetencia() == true)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "Número", "Escudería", "Vueltas", "Combustible");
                Console.WriteLine(primerAuto.MostrarDatos());
            }
            

            Console.ReadKey();


        }
    }
}
