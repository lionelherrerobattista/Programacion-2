using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Clase_05
    {
        static void Main(string[] args)
        {
            int sumaAtras;
            int sumaAdelante;
            string numeroUsuario;
            int numero;
            int centroNumerico = 1;
            int i;

            Console.Title = "Ejercicio Nro 05";

            //Pido el número al usuario:
            Console.WriteLine("Ingrese un número: ");
            numeroUsuario = Console.ReadLine();

            if(int.TryParse(numeroUsuario, out numero))
            {
                do
                {
                    centroNumerico++;//Paso al siguiente número

                    //Reinicio las sumas
                    sumaAtras = 0;
                    sumaAdelante = 0;

                    //Busco la suma de los numeros anteriores al centro
                    for(i = 1; i < centroNumerico; i++)
                    {
                        sumaAtras += i;
                    }

                    //Busco la suma de los números que le siguen al centro
                    i = centroNumerico + 1;//número que le sigue

                    do
                    {
                        sumaAdelante += i;
                        i++;                  

                    } while (sumaAdelante < sumaAtras);

                    //Si las sumas son iguales, imprimo por pantalla
                    if (sumaAdelante == sumaAtras)
                    {
                        Console.WriteLine("{0} ", centroNumerico);
                    }


                } while ( centroNumerico <= numero );//hasta llegar al número que eligió el usuario

                Console.ReadKey();
            }

        }
    }
}
