using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1;
            Punto punto3;
            Rectangulo rectangulo;

            punto1 = new Punto(2, 8);
            punto3 = new Punto(1, 2);

            rectangulo = new Rectangulo(punto1, punto3);

            Console.WriteLine(Rectangulo.MostrarRectangulo(rectangulo));

            Console.ReadKey();

        }

        
    }
}
