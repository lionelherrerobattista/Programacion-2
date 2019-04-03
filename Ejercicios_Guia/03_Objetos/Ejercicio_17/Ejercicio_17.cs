using System;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            string dibujo = "";

            //Creo los objetos boligrafo:
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.Title = "Ejercicio Nro 17";

            //Programa:

            //Establezco el color de la letra
            Console.ForegroundColor = boligrafoAzul.GetColor();
            //Pinto
            boligrafoAzul.Pintar(30, out dibujo);
            //Muestro el dibujo
            Console.Write("{0}\n", dibujo);

            Console.ForegroundColor = boligrafoRojo.GetColor();
            //Pinto
            boligrafoRojo.Pintar(7, out dibujo);
            //Muestro el dibujo
            Console.Write("{0}\n", dibujo);

            Console.ReadKey();


        }
    }
}
