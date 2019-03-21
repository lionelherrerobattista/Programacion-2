using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    class Clase_06
    {
        static void Main(string[] args)
        {
            string auxiliarAnio;
            int anioInicio = 0;
            int anioFin = 0;
            int i; //años entre los elegidos

            Console.Title = "Ejercicio Nro 06";

            Console.Write("Año de inicio: ");
            auxiliarAnio = Console.ReadLine();

            if(int.TryParse(auxiliarAnio, out anioInicio))
            {
                Console.Write("Año de fin: ");
                auxiliarAnio = Console.ReadLine();

                if (int.TryParse(auxiliarAnio, out anioFin))
                {
                    Console.WriteLine("Años bisiestos entre {0} y {1}:", anioInicio, anioFin);

                    for (i = anioInicio; i <= anioFin; i++)
                    {
                        if(i % 4 == 0)
                        {
                            if (i % 100 != 0 || (i % 100 == 0 && i % 400 == 0)) //si es multiplo de 100 y de 400, es bisiesto
                            {

                                Console.Write("{0} ", i);
                            }
                        }
                    }
                    
                }

            }

            Console.ReadKey();
        }

        
    }
}
