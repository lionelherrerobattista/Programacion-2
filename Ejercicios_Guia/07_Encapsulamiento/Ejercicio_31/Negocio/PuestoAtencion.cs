using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{

    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual++;

                return numeroActual;
            }
        }

        public bool AtenderCliente(Cliente cli)
        {
            bool fueAtendido = false;

            System.Threading.Thread.Sleep(3000);

            fueAtendido = true;

            return fueAtendido;






        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto): this()
        {
            this.puesto = puesto;
        }


    }
}
