using System;
using MetodoDeExtension;

namespace Ejercicio_72
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            long numero;

            do
            {
                Console.Write("Ingrese un número: ");
                numeroString = Console.ReadLine();

                if(long.TryParse(numeroString, out numero))
                {
                    Console.WriteLine(String.Format("Número de {0} dígito(s)", numero.CantidadDeDigitos()));
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numérico.");
                    Console.ReadLine();
                }


            } while (numero != 0);
        }
    }
}
