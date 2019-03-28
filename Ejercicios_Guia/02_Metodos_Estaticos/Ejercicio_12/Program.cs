/*12. Realizar un programa que sume números enteros
 * hasta que el usuario lo determine,
 * por medio de un mensaje "¿Continuar? (S/N)".
 * En el método estático ValidaS_N(char c)
 * de la clase ValidarRespuesta, se validará el ingreso de opciones.
 * El método devolverá un valor de tipo booleano,
 * TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{

    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            string numeroAuxiliar;
            int numero;
            int suma = 0;
            char caracter;
            bool respuesta;

            Console.Title = "Ejercicio Nro 12";

            Console.WriteLine("Ingrese los numeros a sumar:");

            do
            {
                //Pido el número a sumar
                Console.Write("Numero: ");
                numeroAuxiliar = Console.ReadLine();

                if(Int32.TryParse(numeroAuxiliar, out numero))
                {

                }

                //Calculo y muestro el resultado
                suma += numero;
                Console.WriteLine("Resultado: {0}", suma);

                //Pregunto al usuario si desea seguir sumando
                Console.Write("\n¿Continuar? (S/N): ");
                caracter = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                //Valido la respuesta
                respuesta = ValidarRespuesta.ValidarS_N(caracter);

            } while (respuesta == true);
        }
    }
}
