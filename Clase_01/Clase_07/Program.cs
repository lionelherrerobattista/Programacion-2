using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            string auxiliarNacimiento;
            int dia = 0;
            int mes = 0;
            int anio = 0;
            string fechaActual;

            Console.WriteLine(DateTime.Now);

            Console.Title = "Ejercicio Nro 07";

            Console.WriteLine("Ingresá tu fecha de nacimiento:");

            Console.Write("Ingresá el día: ");
            auxiliarNacimiento = Console.ReadLine();  

            if(int.TryParse(auxiliarNacimiento, out dia)) //día
            {
                Console.Write("Ingresá el mes: ");
                auxiliarNacimiento = Console.ReadLine();

                if (int.TryParse(auxiliarNacimiento, out mes)) //mes
                {
                    Console.Write("Ingresá el año: ");
                    auxiliarNacimiento = Console.ReadLine();

                    if (int.TryParse(auxiliarNacimiento, out anio))//año
                    {

                    }

                }

            }



        }
    }
}
