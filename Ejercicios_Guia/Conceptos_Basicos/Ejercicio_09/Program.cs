using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            float valorHora = 0;
            string nombre;
            string numeroAuxiliar;
            int antiguedad = 0; //en años
            int horasTrabajadas = 0;
            float totalNeto;
            float totalBruto;
            float descuento;
            char respuesta;

            Console.Title = "Ejercicio Nro 08";
            do
            {


                Console.Write("Ingrese el valor hora: ");
                numeroAuxiliar = Console.ReadLine();
                if (float.TryParse(numeroAuxiliar, out valorHora))
                {

                }

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese la antiguedad: ");
                numeroAuxiliar = Console.ReadLine();
                if (int.TryParse(numeroAuxiliar, out antiguedad))
                {

                }

                Console.Write("Ingrese la cantidad de horas trabajadas: ");
                numeroAuxiliar = Console.ReadLine();
                if (int.TryParse(numeroAuxiliar, out horasTrabajadas))
                {

                }

                totalBruto = horasTrabajadas * valorHora + (antiguedad * 150);
                descuento = (totalBruto * 0.13f);
                totalNeto = totalBruto - descuento;

                Console.WriteLine(totalNeto);

                Console.ReadLine();
                Console.WriteLine("{0,5} {1,5} {2,5} {3,5} {4,5} {5,5}", "Nombre", "Antiguedad", "Valor Hora", "Bruto", "Descuentos", "Neto" );
                Console.WriteLine("{0,5}{1,5}{2,15}{3,10}{4,10}{5,10}", nombre, antiguedad, valorHora, totalBruto, descuento, totalNeto);

                Console.WriteLine("¿Desea seguir ingresando empleados? (s/n) ");
                respuesta = Convert.ToChar(Console.ReadLine());

            } while (respuesta != 'n');
    

        }
    }
}
