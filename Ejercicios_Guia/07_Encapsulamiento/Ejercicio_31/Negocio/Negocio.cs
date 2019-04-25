using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
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
                return clientes.Dequeue();
            }
            set
            {
                if(!(clientes.Contains(value)))
                {
                    clientes.Enqueue(value);
                }
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
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }
        public static bool operator ~(Negocio n)
        {
            bool clienteAtendido = false;

            if(n.caja.AtenderCliente(n.clientes.Dequeue()))
            {
                clienteAtendido = true;
            }

            return clienteAtendido;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool agregoCliente = false;

            n.Cliente = c;         

            if(n != c)
            {
                agregoCliente = true;
            }

            return agregoCliente;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
            
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool sonIguales = false;

            if(n.clientes.Contains(c))
            {
                sonIguales = true;
            }

            return sonIguales;

        }
        

        
            
    }
}
