using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            //Llevan valores iniciales:
            int maximo = int.MinValue; //Le asigno el valor mínimo
            int minimo = int.MaxValue; //Le asigno el valor máximo
            int i=0;
            int acumuladorNumeros = 0;
            float promedio;
            int numeroAuxiliar;
        

            Console.Title = "Ejercicio Nro 01";

            Console.WriteLine("Ingrese 5 números:");
            do
            {
                if (int.TryParse(Console.ReadLine(), out numeroAuxiliar)) //devuelve bool
                {
                    acumuladorNumeros += numeroAuxiliar;

                    if (numeroAuxiliar > maximo)
                    {
                        maximo = numeroAuxiliar;
                    }

                    if (numeroAuxiliar < minimo)
                    {
                        minimo = numeroAuxiliar;
                    }

                }
                else
                {
                    Console.WriteLine("Error");
                }

                i++;

            } while (i < 5);

            //Calculo el promedio
            promedio = (float)acumuladorNumeros / 5;

            Console.WriteLine("Promedio {0}", promedio);
            Console.WriteLine("Mayor {0}", maximo);
            Console.WriteLine("Menor {0}", minimo);

            Console.ReadKey();

        }
    }
}
