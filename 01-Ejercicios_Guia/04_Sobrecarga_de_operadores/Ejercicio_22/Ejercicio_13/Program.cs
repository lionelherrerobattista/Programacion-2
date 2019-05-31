/* 13. Desarrollar una clase llamada Conversor, que posea dos métodos
 * de clase (estáticos):
 * string DecimalBinario(double). Convierte un número de decimal a binario.
 * double BinarioDecimal(string). Convierte un número binario a decimal.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{

    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            Console.Title = "Ejercicio Nro 22";

            Console.WriteLine("Número Binario:{0}\nNúmero Decimal:{1}",
                (string)objBinario, (double)objDecimal);

            if(objBinario == objDecimal)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Console.Write("Resta en binario: ");
            Console.WriteLine(objBinario - objDecimal);
            Console.Write("Suma en binario: ");
            Console.WriteLine(objBinario + objDecimal);
            Console.Write("Resta en decimal: ");
            Console.WriteLine(objDecimal - objBinario);
            Console.Write("Suma en decimal: ");
            Console.WriteLine(objDecimal + objBinario);

            Console.ReadKey();

        }
    }
}
