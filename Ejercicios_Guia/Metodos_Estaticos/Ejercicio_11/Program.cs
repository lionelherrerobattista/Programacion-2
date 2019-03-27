/* 11. Ingresar 10 números enteros que pueden estar dentro de un rango
 * de entre -100 y 100. Para ello realizar una clase llamada Validacion
 * que posea un método estático llamado Validar,
 * que posea la siguiente firma: bool Validar(int valor, int min, int max):
 * a. valor: dato a validar
 * b. min y max: rango en el cual deberá estar la variable valor.
 * Terminado el ingreso mostrar el valor mínimo, el valor máximo
 * y el promedio. Nota: Utilizar variables escalares,
 * NO utilizar vectores. 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool valido = false;

            //Compruebo que el número se encuentre dentro del rango
            if (valor <= max && valor >= min)
            {
                valido = true; //valido el número
            }

            return valido;

        }

    }

    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            int i;
            string numeroAuxiliar;
            int valor;
            int minimo = Int32.MaxValue;
            int maximo = Int32.MinValue;
            float promedio;
            int acumuladorNumeros = 0;
            bool validado;

            Console.Title = "Ejercicio Nro 11";

            Console.WriteLine("Ingrese 10 números: ");
            

            //Pido los 10 números
            for(i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write("Número {0}: ", i + 1);
                    numeroAuxiliar = Console.ReadLine();
                    
                    //Todavía el número no está validado:
                    validado = false;    
                    
                    if (Int32.TryParse(numeroAuxiliar, out valor))
                    {
                        //valido el número
                        validado = Validacion.Validar(valor, -100, 100);
                    }

                    //Si no lo pudo validar
                    if(validado == false)
                    {
                        Console.WriteLine("Error. Fuera de rango"
                            + " Ingrese el número nuevamente.");
                    }
                    else //si pudo validar
                    {
                        //voy sumando los números:
                        acumuladorNumeros += valor;

                        //compruebo si es menor o mayor
                        if(valor > maximo)
                        {
                            maximo = valor;

                        }

                        if(valor < minimo)
                        {
                            minimo = valor;
                        }
                    }

                } while (validado == false);

            }//fin del for

            //calculo el promedio
            promedio = (float)acumuladorNumeros / 10;

            //Muestro los resultados
            Console.WriteLine("\nMáximo: {0} \nMínimo:{1}"
                + "\nPromedio:{2,3}", maximo, minimo, promedio);

            Console.ReadKey();
        }
    }
}
