using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            double numeroUno;
            double numeroDos;
            double resultado;
            char operacion;
            string numeroAuxiliar;

            Console.Title = "Ejercicio Nro 15";

            Console.Write("Ingrese el numero 1: ");
            numeroAuxiliar = Console.ReadLine();

            if(Double.TryParse(numeroAuxiliar, out numeroUno))
            {

            }

            Console.Write("Ingrese el numero 2: ");
            numeroAuxiliar = Console.ReadLine();

            if (Double.TryParse(numeroAuxiliar, out numeroDos))
            {

            }

            Console.Write("Ingrese la operación: ");
            operacion = Console.ReadKey().KeyChar;

            resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);

            Console.WriteLine("\nResultado: {0}", resultado);

            Console.ReadKey();

        }
    }
}
