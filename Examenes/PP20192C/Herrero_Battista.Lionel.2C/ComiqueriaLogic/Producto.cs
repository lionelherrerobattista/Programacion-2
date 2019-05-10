using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;

                }
                

            }
            
        }

        /// <summary>
        /// Inicializa el campo codigo co el metodo estatico NewGuid de la clase Guid
        /// </summary>
        /// <param name="descripcion"> descripcion del producto</param>
        /// <param name="stock">cantidad de stock</param>
        /// <param name="precio">precio del producto</param>
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.Stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        /// <summary>
        /// Sobrecarga el metodo ToString() para mostrar los datos del producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Descripcion: {0}\n", this.Descripcion);
            datos.AppendFormat("Código: {0}\n", (Guid)this);
            datos.AppendFormat("Precio: $ {0:#,###.00}\n", this.Precio);
            datos.AppendFormat("Stock: {0} unidades\n", this.Stock);
            

            return datos.ToString();

        }






    }
}
