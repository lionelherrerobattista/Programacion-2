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
            int numero;
            
            List<int> listaNumeros;
            Queue<int> colaPositivos;
            Queue<int> colaNegativos;
            Stack<int> pilaPostivos;
            Stack<int> pilaNegativos;

            listaNumeros = new List<int>();
            colaPositivos = new Queue<int>();
            colaNegativos = new Queue<int>();
            pilaPostivos = new Stack<int>();
            pilaNegativos = new Stack<int>();

            Random random = new Random();

            //
            //Lista

            //Agrego 20 números
            for (i = 0; i < 20; i++)
            {
                do
                {
                    numero = random.Next(-100, 100);

                    if (numero != 0)
                    {
                        listaNumeros.Add(numero);
                        break;
                    }

                } while (numero == 0);
            }

            //Muestro los números en la lista
            Console.WriteLine("Lista sin ordenar: ");
            foreach (int num in listaNumeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nLista ordenada: ");
            listaNumeros.Sort(Program.OrdenarLista);//ordeno la lista en forma decreciente
            foreach (int num in listaNumeros)
            {
                Console.WriteLine(num);
            }


            //Muestro los positivos ordenados en forma decreciente
            Console.WriteLine("\nLista números positivos: ");
            foreach (int num in listaNumeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                    colaPositivos.Enqueue(num);
                }
                else
                {
                    //pila, primero en entrar, ultimo en salir
                    pilaNegativos.Push(num);
                }
              
            }

            //
            //Muestro numeros negativos en orden creciente
            Console.WriteLine("\nLista números negativos:");
            for (i = listaNumeros.Count - 1; i >= 0; i--)
            {
                if(listaNumeros[i] < 0)
                {
                    Console.WriteLine(listaNumeros[i]);
                    colaNegativos.Enqueue(listaNumeros[i]);
                }
                else
                {
                    pilaPostivos.Push(listaNumeros[i]);
                }
                
            }

            //
            //Colas

            Console.WriteLine("\nCola números positivos: ");
            foreach (int num in colaPositivos)//primero en entrar, primero en salir
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nCola números negativos: ");
            foreach (int num in colaNegativos)
            {
                Console.WriteLine(num);
            }

            //
            //Pilas

            Console.WriteLine("\nPila números positivos:");
            foreach (int num in pilaPostivos)//primero en entrar, ultimo en salir
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("\nPila números negativos:");
            foreach(int num in pilaNegativos)
            {
                Console.WriteLine(num);
            }
            

            Console.ReadKey();

        }

        /// <summary>
        /// Función que ordena de mayor a menor
        /// </summary>
        /// <param name="num1">Primer número a comparar</param>
        /// <param name="num2">Segundo número a comparar</param>
        /// <returns>-1 si el primero es mayor, 0 si son iguales, 1 si el segundo es mayor</returns>
        public static int OrdenarLista(int num1, int num2)
        {
            int retorno = 0;

            if(num1 > num2)
            {
                retorno = -1;
              
            }
            else if(num2> num1)
            {
                retorno = 1;
            }

            return retorno;
                
                

        }
        

    }
}


        
    

