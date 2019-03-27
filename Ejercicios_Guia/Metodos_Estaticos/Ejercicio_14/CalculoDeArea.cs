using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {

        public static double CalcularCuadrado(double baseCuadrado)
        {
            double area;

            area = baseCuadrado * baseCuadrado;

            return area;
        }

        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double area;

            area = (baseTriangulo * alturaTriangulo) / 2;

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area;

            area = Math.Pow((Math.PI * radio), 2);

            return area;
        }

    }
}
