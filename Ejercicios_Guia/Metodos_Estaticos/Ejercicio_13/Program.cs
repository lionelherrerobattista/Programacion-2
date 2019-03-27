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
            double numero;
            double numeroDos;
            string binario;

            Console.Title = "Ejercicio Nro 13";

            numero = 25;

            binario = Conversor.DecimalBinario(numero);

            Console.WriteLine(binario);

            numeroDos = Conversor.BinarioDecimal(binario);
            Console.WriteLine("Vuelvo a convertir: {0}",numeroDos);

            Console.ReadKey();

        }
    }
}
