using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool respuesta;

                respuesta = (this + value);
                
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }


        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }


        public static bool operator ~(Negocio n)
        {
            bool clienteAtendido = false;

            if (n.caja.AtenderCliente(n.Cliente))//uso getter
            {
                clienteAtendido = true;
            }

            return clienteAtendido;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool agregoCliente = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);//uso setter

                if (n.clientes.Contains(c))
                {
                    agregoCliente = true;
                }

            }

            return agregoCliente;
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool sonIguales = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    sonIguales = true;
                    break;
                }
            }

            

            return sonIguales;

        }
        

        
            
    }
}
