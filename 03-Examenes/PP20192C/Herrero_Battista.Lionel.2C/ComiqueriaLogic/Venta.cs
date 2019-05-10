using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);


        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double resultado;

            resultado = cantidad * precioUnidad;
            resultado = resultado + ((double)(porcentajeIva * resultado) / 100);

            return resultado;

        }

        public string ObtenerDescripcionBreve()
        {
            return String.Format("{0} - {1} - $ {2:#,###.00}", this.Fecha, this.producto.Descripcion, this.precioFinal);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

    }
}
