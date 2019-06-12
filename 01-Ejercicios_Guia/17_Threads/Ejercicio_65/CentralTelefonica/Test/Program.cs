using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            string encabezado;

            Centralita c;

            Thread tLlamadas;

            Console.Title = "Ejercicio Nro 59";

            // Mi central
            c = new Centralita("Fede Center");

            tLlamadas = new Thread(new ParameterizedThreadStart(SimularLlamada));

            tLlamadas.Start(c);

            encabezado = String.Format("\n{0, 3} {1, 10} {2, 15} {3, 15}", "Duracion",
                "Destino", "Origen", "Costo");


            do
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.Ver Llamadas Local.");
                Console.WriteLine("2.Ver Llamadas Provincial.");
                Console.WriteLine("3.Ver Llamadas Todas.");
                Console.WriteLine("4.Salir.");
                Console.WriteLine("-----------------");
                Console.Write("Elija una opción: ");

                if(Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine(encabezado);

                    foreach (Llamada llamadaAux in c.Llamadas)
                    {
                        switch ((TipoLlamada)(opcion-1))
                        {
                            case TipoLlamada.Local:
                                if (llamadaAux is Local)
                                {
                                    Console.WriteLine(llamadaAux.ToString());
                                }
                                break;
                            case TipoLlamada.Provincial:
                                if (llamadaAux is Provincial)
                                {
                                    Console.WriteLine(llamadaAux.ToString());
                                    
                                }
                                break;
                            default:
                                Console.WriteLine(llamadaAux.ToString());                               
                                break;
                        }

                    }
                }

            } while (opcion != 4);

            
            if(tLlamadas.IsAlive)
            {
                tLlamadas.Abort();
            }

        }

        public static void SimularLlamada(object centralita)
        {
            string numeroDestino;
            string numeroOrigen;
            int duracion;
            int franja;
            float costo;
            int opcion;
            
            Random random;

            Local auxLocal;
            Provincial auxProvincial;

            random = new Random();


            do
            {
                opcion = random.Next(1, 3);
                duracion = random.Next(1, 60);

                switch (opcion)
                {
                    case 1://Local
                        numeroDestino = random.Next(40000000, 50000000).ToString();
                        numeroOrigen = random.Next(40000000, 50000000).ToString();
                        costo = random.Next(10, 100) / 10f;
                        

                        auxLocal = new Local(numeroOrigen, duracion, numeroDestino, costo);


                        centralita = (Centralita)centralita + auxLocal;
                        break;
                    case 2://Provincial
                        numeroDestino = random.Next(20000000, 500000000).ToString();
                        numeroOrigen = random.Next(20000000, 500000000).ToString();
                        franja = random.Next(0, 3);

                        auxProvincial = new Provincial(numeroOrigen, (Provincial.Franja)franja, duracion, numeroDestino);

                        centralita = (Centralita)centralita + auxProvincial;
                        break;
                }
                

                Thread.Sleep(random.Next(1000, 5000));

            } while (true);
        }


    }
}
