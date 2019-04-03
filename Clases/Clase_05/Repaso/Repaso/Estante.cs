using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            string informacion;
            //estante
            informacion = String.Format("Ubicación estante: {0}\n", e.ubicacionEstante);
            
            //detalle de cada uno de los productos
            for (i = 0; i < e.productos.Length; i++)
            {
                if(!(Object.Equals(e.productos[i], null)))
                {
                    informacion += Producto.MostrarProducto(e.productos[i]);
                }
                
            }

            
            return informacion;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            Estante estanteAuxiliar = new Estante(e.productos.Length);

            if (e == p)//si el producto está en el estante
            {
                estanteAuxiliar = e;

                for (i = 0; i < e.productos.Length-1; i++)
                {
                    if(estanteAuxiliar.productos[i] == p)
                    {
                        estanteAuxiliar.productos[i] = null;//Le saco la referencia
                        break;
                    }
                }
 
            }

            return estanteAuxiliar;
        }

        public static bool operator +(Estante e, Producto p)
        {
            int i;
            bool agrego = false;

            if(e != p)//si no está el producto en el estante
            {
                for(i = 0; i < e.productos.Length; i++)
                {
                    if(Object.Equals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        agrego = true;
                        break;
                    }
                }
            }

            return agrego;

        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool noEsta = true;
            int i;

            for(i = 0; i < e.productos.Length; i++)
            {
                if (Object.Equals(e.productos[i], p))
                {
                    noEsta = false;
                    break;
                }
            }

            return noEsta;

        }


        public static bool operator ==(Estante e, Producto p)
        {
            bool esta = false;
            int i;

            for (i = 0; i < e.productos.Length; i++)
            {
                if (Object.Equals(e.productos[i], p))
                {
                    esta = true;
                    break;
                }
            }

            return esta;

        }


    }
}
