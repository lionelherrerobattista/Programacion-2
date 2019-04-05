using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            //Pruebo crear los objetos
            Dolar d1 = new Dolar(20);
            Euro e1 = new Euro(2);
            Pesos p1 = new Pesos(20);
            Dolar d2 = new Dolar(0);
            Pesos p2 = new Pesos(0);

            Console.Title = "Ejercicio Nro 20";

            //Pruebo comparación
            if (p1 == d1)
            {
                Console.WriteLine("Son iguales.");
            }

            //Pruebo operadores
            d1 = d1 - e1;
            p2 = p1 + e1;

            Console.WriteLine(d1.GetCantidad());

            Console.ReadKey();

            

        }
    }
}
