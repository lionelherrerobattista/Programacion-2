using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio34;

namespace Ejercicio_34
{
    class Ejercicio_34
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_34";

            Automovil nuevoAuto = new Automovil(4, 4, Colores.Azul, 6, 2);
            Camion nuevoCamion = new Camion(8, 2, Colores.Blanco, 5, 200);
            Moto nuevaMoto = new Moto(2, 0, Colores.Negro, 90);

            if(!(nuevoAuto is null))
            {
                Console.WriteLine("Auto Creado");
            }
            if (!(nuevoCamion is null))
            {
                Console.WriteLine("Camión Creado");
            }
            if (!(nuevaMoto is null))
            {
                Console.WriteLine("Moto Creada");
            }


            Console.ReadKey();

            

        }
    }
}
