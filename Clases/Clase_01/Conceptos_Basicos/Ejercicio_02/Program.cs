using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            double numeroUsuario;
            string numeroAuxiliar;
          
        

            Console.Title = "Ejercicio Nro 02";

            do
            {

                Console.Write("Ingrese un numero: ");

                numeroAuxiliar = Console.ReadLine();

                if (double.TryParse(numeroAuxiliar, out numeroUsuario)) //devuelve bool
                {
                    Console.WriteLine("El número es {0}", numeroUsuario);
                }
                
                if(numeroUsuario < 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

                
           
            } while (numeroUsuario < 0);

                Console.WriteLine("Al cuadrado: {0}", Math.Pow(numeroUsuario, 2));
                Console.WriteLine("Al cubo: {0}", Math.Pow(numeroUsuario, 3));
            


            Console.ReadKey();

                

        }
    }
}
