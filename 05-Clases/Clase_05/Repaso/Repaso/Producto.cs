using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return String.Format("  {0,-10}{1,13}{2,10}\n", p.codigoDeBarra, p.marca, p.precio);
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool distintaMarca = false;

            if (p.marca != marca)
            {
                distintaMarca = true;
            }

            return distintaMarca;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool distintoProducto = false;

            if(p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                distintoProducto = true;
            }

            return distintoProducto;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool mismaMarca = false;

            if(p.marca == marca)
            {
                mismaMarca = true;
            }

            return mismaMarca;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool mismoProducto = false;

            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                mismoProducto = true;
            }

            return mismoProducto;
        }

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
    }
}
