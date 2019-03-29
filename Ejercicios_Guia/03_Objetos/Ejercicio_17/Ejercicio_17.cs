using System;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            short tintaBoligrafo;

            tintaBoligrafo = 100;

            Boligrafo boligrafoAzul = new Boligrafo(tintaBoligrafo, ConsoleColor.Blue);

            tintaBoligrafo = 50;

            Boligrafo boligrafoRojo = new Boligrafo(tintaBoligrafo, ConsoleColor.Red);

            Console.Title = "Ejercicio Nro 17";
        }
    }
}
