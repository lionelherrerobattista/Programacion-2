using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            long resultadoNumero;
            string resultadoString;
            long resultado;

            Console.Title = "Ejercicio Nro 19";

            //Creo un objeto de la clase Sumador
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador(2);

            //Prueba sumar numeros:
            resultadoNumero =  suma1.Sumar(5, 6);
            Console.WriteLine(resultadoNumero);

            //Prueba sumar strings
            resultadoString = suma1.Sumar("Hola ", "Lionel");
            Console.WriteLine(resultadoString);

            //Prueba sobrecarga de operadores:
            resultado = suma1 + suma2; //Sobrecarga: sumo la cantidad de sumas realizadas
            Console.WriteLine(resultado);

            if(suma1 | suma2)//Sobrecarga: si cant. sumas son iguales
            {
                Console.WriteLine("Son iguales");//(2 y 2)
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            Console.ReadKey();



        }
    }
}
