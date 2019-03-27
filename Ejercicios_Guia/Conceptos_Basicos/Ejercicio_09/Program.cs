using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            string auxiliarNumero;
            int altura;
            int ancho = 1;
            int i;
            int j;

            Console.Title = "Ejercicio Nro 09";

            Console.WriteLine("Ingrese la altura del triángulo: ");
            auxiliarNumero = Console.ReadLine();

            if(int.TryParse(auxiliarNumero, out altura))
            {
                for(i = 0; i < altura; i++)
                {
                    for(j = 0; j < ancho; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                    ancho++;
                }

            }

            Console.ReadKey();
        }
    }
}
