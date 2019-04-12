using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [20];
            int numero = 0;
            int i;
            int j;

            Random random = new Random();

            for(i = 0; i < 20; i++)
            {
                do
                {
                    numero = random.Next(-100, 100);

                    if (numero != 0)
                        numeros[i] = numero;

                } while (numero != 0);
               
            }

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", numeros[i]);
            }

            Console.WriteLine("\n");

            //Ordeno positivos
            //
            for (i = 0; i < numeros.Length-1; i++)
            {
                    for (j = i+1; j < numeros.Length ; j++)
                    {
                        if (numeros[i] < numeros[j] && numeros[j] > 0)
                        {
                            numero = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = numero;
                        }

                    }

            }

            Console.WriteLine("Positivos ordenados");

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", numeros[i]);
            }

            Console.WriteLine();

            //Ordeno negativos
            //

            for (i = 0; i < numeros.Length - 1; i++)
            {
                if (numeros[i] > 0)
                {
                    continue;
                }
                for (j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j] && numeros[j] < 0)
                    {

                        numero = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = numero;
                    }

                }

            }

            Console.WriteLine("Negativos ordenados");

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", numeros[i]);
            }





            Console.ReadKey();

        }
    }
}
