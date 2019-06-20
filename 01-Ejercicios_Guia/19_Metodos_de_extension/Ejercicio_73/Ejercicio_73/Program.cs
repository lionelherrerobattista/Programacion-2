using System;
using MetodoDeExtensionString;

namespace Ejercicio_73
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            do
            {
                Console.WriteLine("Ingrese una frase para contar sus signos de puntuación: ");

                palabra = Console.ReadLine();

                Console.WriteLine(String.Format("El texto tiene {0} signos de puntuación", palabra.CantidadSignosPuntuacion()));


            } while (palabra != String.Empty);
        }
    }
}
