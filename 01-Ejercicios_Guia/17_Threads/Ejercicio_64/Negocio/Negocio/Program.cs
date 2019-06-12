using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Negocio;
using System.Threading;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1;
            Caja c2;

            Negocio negocio;

            Thread tNegocio;
            Thread tCaja1;
            Thread tCaja2;

            c1 = new Caja();
            c2 = new Caja();

            negocio = new Negocio(c1, c2);

            tNegocio = new Thread(negocio.AsignarCaja);
            tCaja1 = new Thread(c1.AtenderClientes);
            tCaja2 = new Thread(c2.AtenderClientes);

            negocio.Clientes.Add("Juan");
            negocio.Clientes.Add("María");
            negocio.Clientes.Add("Pedro");
            negocio.Clientes.Add("Laura");

            tCaja1.Name = "Caja 1";
            tCaja2.Name = "Caja 2";

            tNegocio.Start();
            
            tNegocio.Join();//Pauso la ejecución del Main hasta que termine de ejecutarse tNegocio

            tCaja1.Start();
            tCaja2.Start();

            Console.ReadKey();
        }
    }
}
