using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero = 0;
            Stack<int> numeros;

            numeros = new Stack<int>();

            Random random = new Random();

            for (i = 0; i < 20; i++)
            {
                do
                {
                    numero = random.Next(-100, 100);

                    if (numero != 0)
                        numeros.Push(numero);

                } while (numero != 0);
            }


            Console.WriteLine(numeros.Peek());
            for(i = 0;)
            Console.WriteLine(numeros.ElementAt(i);


            Console.ReadKey();
        }

    }
}


        
    

