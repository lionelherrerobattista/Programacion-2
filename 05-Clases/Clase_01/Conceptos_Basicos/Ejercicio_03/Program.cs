using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            int divisores = 0;//Contador divisores
            int numeroUsuario;
            string numeroAuxiliar;
            int i;
            int j;

            Console.Title = "Ejercicio Nro 03";

            Console.Write("Ingrese un número para ver los números primos anteriores: ");
            numeroAuxiliar = Console.ReadLine();

            if (int.TryParse(numeroAuxiliar, out numeroUsuario))
            {
                Console.WriteLine("Numero: {0}", numeroUsuario);
                Console.WriteLine("Numeros primos: ");
                for (i = 1; i <= numeroUsuario; i++)
                {
                    divisores = 0;

                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            divisores++;
                        }

                        if (divisores > 3)
                        {
                            break;
                        }

                    }

                    
                    if (divisores == 2)
                    {
                        Console.Write("{0} ", i);
                    }

                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            

            Console.ReadKey();
        }
    }
}
