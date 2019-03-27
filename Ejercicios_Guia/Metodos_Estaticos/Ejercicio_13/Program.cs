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
    class Conversor
    {
        //Convierte un número de decimal a binario
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            string retorno = "";
            int i;

            do
            {
                //Si es par
                if(numero % 2 == 0)
                {
                    binario += "0";                    
                }
                else
                {
                    binario += "1";
                }

                //divido
                numero = numero / 2;
  
            } while (numero > 1 );

            for (i = binario.Length - 1; i > 0; i-- )
            {
                retorno += binario[i];
            }

            return binario;
        }

        /*
        static double BinarioDecimal(string numero)
        {

        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string binario;

            numero = 10;

            binario = Conversor.DecimalBinario(numero);

            Console.WriteLine(binario);

            Console.ReadKey();

        }
    }
}
