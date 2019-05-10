using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
                PuestoAtencion.numeroActual++;

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

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }


    }
}
