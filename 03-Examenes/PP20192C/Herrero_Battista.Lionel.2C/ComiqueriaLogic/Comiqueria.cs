using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {

                Producto producto = null;

                foreach(Producto p in this.productos)
                {
                    if((Guid)p == codigo)
                    {
                        producto = p;
                        break;
                    }

                }


                return producto;
            }
        }

        /// <summary>
        /// Instancia los campos de List
        /// </summary>
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();

        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> listarProductos = new Dictionary<Guid, string>();
            
            foreach(Producto p in this.productos)
            {
                listarProductos.Add((Guid)p, p.Descripcion);
            }

            return listarProductos;
        }

        public string ListarVentas()
        {
            StringBuilder datos = new StringBuilder();

            this.ventas.Sort(ordenarFecha);

            foreach(Venta v in this.ventas)
            {
                datos.Append(v.ObtenerDescripcionBreve());
                datos.AppendLine();
            }

            return datos.ToString();
        }

        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta v = new Venta(producto, cantidad);
            this.ventas.Add(v);
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);

        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool sonIguales = false;

            foreach(Producto productoAux in comiqueria.productos)
            {
                if(productoAux.Descripcion == producto.Descripcion)
                {
                    sonIguales = true;
                }
            }

            return sonIguales;


        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }

        internal static int ordenarFecha(Venta fecha1, Venta fecha2)
        {
            int retorno = 0;


            if(fecha1.Fecha < fecha2.Fecha)
            {
                retorno = 1;//ordenar
            }
            else if(fecha1.Fecha > fecha2.Fecha)
            {
                retorno = -1;//no ordenar
            }


            return retorno;
        }
    }
}
