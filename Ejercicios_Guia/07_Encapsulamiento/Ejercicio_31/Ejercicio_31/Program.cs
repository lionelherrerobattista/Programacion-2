using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_31";

            Negocio farmacia = new Negocio("Farmacity");

            Cliente clienteUno = new Cliente(1, "Juan");
            Cliente clienteDos = new Cliente(3, "Pedro");
            Cliente clienteTres = new Cliente(2, "María");
            Cliente clienteCuatro = new Cliente(2, "Laura");


            //Agrego los clientes a la cola
            farmacia.Cliente = clienteUno;
            farmacia.Cliente = clienteDos;
            farmacia.Cliente = clienteTres;
            farmacia.Cliente = clienteCuatro;

            if (~farmacia)
                Console.WriteLine("Cliente atendido");

            Console.WriteLine(farmacia.Cliente.Nombre);
            Console.WriteLine(farmacia.ClientesPendientes);


            Console.ReadKey();

        }
    }
}
