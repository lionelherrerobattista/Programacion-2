using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseCuadrado;
            double areaCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double areaTriangulo;
            double radioCirculo;
            double areaCirculo;
            string numeroAuxiliar;

            //Cuadrado
            Console.Write("Ingrese la base del cuadrado: ");
            numeroAuxiliar = Console.ReadLine();

            if(Double.TryParse(numeroAuxiliar, out baseCuadrado))
            {
                areaCuadrado = CalculoDeArea.CalcularCuadrado(baseCuadrado);

                Console.WriteLine("\nCuadrado:");
                Console.WriteLine("Base: {0}", baseCuadrado);
                Console.WriteLine("Area: {0}", areaCuadrado);
            }

            //Triángulo
            Console.Write("\nIngrese la base del triángulo: ");
            numeroAuxiliar = Console.ReadLine();

            if (Double.TryParse(numeroAuxiliar, out baseTriangulo))
            {
                Console.Write("Ingrese la altura del triángulo: ");
                numeroAuxiliar = Console.ReadLine();

                if (Double.TryParse(numeroAuxiliar, out alturaTriangulo))
                {
                    areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);

                    Console.WriteLine("\nTriángulo:");
                    Console.WriteLine("Base: {0}", baseTriangulo);
                    Console.WriteLine("Altura: {0}", alturaTriangulo);
                    Console.WriteLine("Area: {0}", areaTriangulo);

                }

            }





            //Círculo

            Console.Write("\nIngrese el radio del círculo: ");
            numeroAuxiliar = Console.ReadLine();

            if (Double.TryParse(numeroAuxiliar, out radioCirculo))
            {
                areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);

                Console.WriteLine("\nCírculo:");
                Console.WriteLine("Radio: {0}", radioCirculo);
                Console.WriteLine("Area: {0:0.###}", areaCirculo);
            }

            Console.ReadKey();

        }
    }
}
