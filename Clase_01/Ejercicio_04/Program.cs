using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            int acumuladorDivisores;//Suma los divisores
            int numerosPerfectos = 0;
            int i=6;// 6 es el primer número perfecto
            int j;//Para los divisores

            Console.Title = "Ejercicio Nro 04";

            Console.WriteLine("Primeros 4 números perfectos: ");

            do
            {
                acumuladorDivisores = 0;

                for(j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        acumuladorDivisores += j;
                    }
                }

                if(acumuladorDivisores == i)//Si la suma coincide, muestro
                {
                    numerosPerfectos++;
                    Console.Write("{0} ", i);
                }

                i++;
                

            } while (numerosPerfectos < 4);//Cuando encontré 4 salgo

            Console.ReadKey();


                


        }
    }
}
