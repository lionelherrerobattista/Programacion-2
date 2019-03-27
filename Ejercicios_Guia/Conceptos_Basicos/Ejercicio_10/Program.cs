using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int ancho = 1;
            int i;
            int j;
            string auxiliarNumero;

            //Pido la altura
            Console.Write("Ingrese la altura del triángulo: ");
            auxiliarNumero = Console.ReadLine();

            if(Int32.TryParse(auxiliarNumero, out altura))
            {
                //Dibujo el triángulo al revés
                for(i = altura; i > 0; i--)
                {
                    //Primero más espacios que asteriscos
                    for(j = altura - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    for(j = 0; j < ancho; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                    //sumo al ancho y resto a la altura
                    ancho += 2;//Me muevo de impar a impar
                    altura--;//resto para dibujar el triángulo al revés
                }


            }

            Console.ReadKey();

        }
    }
}
