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
            int i;
            int dia = 0;
            int mes = 0;
            int anio = 0;
            int diaHoy = 0;
            int contadorBisiesto = 0;
            int anioHoy = 0;
            int aniosVividos = 0;
            int diasVividos = 0;

            Console.Title = "Ejercicio Nro 07";


            diaHoy = DateTime.Now.DayOfYear; //obtengo el numero de día
            anioHoy = DateTime.Now.Year;



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
                        
                        if(anio != anioHoy)
                        {
                            //primer año
                            for (i = mes; i <= 12; i++)
                            {
                                if (i % 2 == 0 || i == 9 || i == 11)
                                {
                                    if(i != 2)
                                    {
                                        if(i == 12 || i == 8 || i == 10)
                                        {
                                            diasVividos += 31;
                                        }
                                        else
                                        {
                                            diasVividos += 30;
                                        }

                                        
                                    }
                                    else
                                    {
                                        diasVividos += 28;
                                    }
                                    
                                }
                                else
                                {
                                    diasVividos += 31;
                                }

                            }
                            Console.WriteLine(diasVividos);
                            //le resto el día que nació
                            diasVividos -= dia;

                            //Sin contar primer año ni ultimo año
                            if(anioHoy - anio > 1)
                            {
                                for (i = anio; i <= anioHoy; i++)
                                {
                                    if (i % 4 == 0)
                                    {
                                        if (i % 100 != 0 || (i % 100 == 0 && i % 400 == 0)) //si es multiplo de 100 y de 400, es bisiesto
                                        {

                                            contadorBisiesto++;
                                        }
                                    }
                                }

                                //Cuento el resto de los años teniendo en cuenta los bisiestos
                                aniosVividos = anioHoy - (anio + 1);
                                aniosVividos -= contadorBisiesto;
                                diasVividos += (aniosVividos * 365) + contadorBisiesto;
                            }


                        }
                        

                        //Contando ultimo año
                        diasVividos += diaHoy;

                        //Muestro
                        Console.WriteLine(diasVividos);

                        Console.ReadKey();
                    }

                }

            }



        }
    }
}
