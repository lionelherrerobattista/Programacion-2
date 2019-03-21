using System;
using System.Globalization;
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
            int diaHoy = 0;
            int mesHoy = 0;
            int anioHoy = 0;
            int aniosVividos = 0;
            int diasVividos = 0;
            int mesesCalculo = 0;
            int diasCalculo = 0;
            int diasTotalesUsuario = 0;
            int diasTotalesActual = 0;
            int resultado = 0;
            string fechaHoy;

            Console.Title = "Ejercicio Nro 07";

            DateTime fechaActual = DateTime.Now;

            fechaHoy = fechaActual.ToString("d", DateTimeFormatInfo.InvariantInfo);
            Console.WriteLine(fechaHoy);


            int.TryParse(fechaHoy.Substring(3, 2), out diaHoy);
            int.TryParse(fechaHoy.Substring(0, 2), out mesHoy);
            int.TryParse(fechaHoy.Substring(6, 4), out anioHoy);

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
                        aniosVividos = (anioHoy - 1) - anio;
                        diasVividos = aniosVividos * 365;
                        //Sin contar ultimo año
                        Console.WriteLine(aniosVividos);
                        Console.WriteLine(diasVividos);
                        //Contando ultimo año
                         
                        resultado = diasCalculo;

                        Console.ReadKey();
                    }

                }

            }



        }
    }
}
