using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar = 1;

        //Constructores
        private Dolar()
        {
            new Dolar(0);
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)//uso operador this para llamar a la función
        {
            cotizRespectoDolar = cotizacion;
        }

        //Sobrecarga operadores (compatibilidad distintos tipos de datos):
        public static explicit operator Euro(Dolar d)//Para poder operar con Euro
        {
            return d.GetCantidad() / Euro.GetCotizacion();
        }

        public static explicit operator Pesos(Dolar d)//Para poder operar con Pesos
        {
            return d.GetCantidad() * Pesos.GetCotizacion();
        }

        public static implicit operator Dolar(double d)
        {
            Dolar d1 = new Dolar(d);

            return d1;
        }

        //Métodos:
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //Sobrecarga de operadores
        public static bool operator !=(Dolar d, Euro e)
        {
            bool distinto = false;

            if (d.GetCantidad() != e.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool distinto = false;

            if (d.GetCantidad() != p.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool distinto = false;

            if (d1.GetCantidad() != d2.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar conversionDolar = new Dolar();

            conversionDolar = (Dolar)e;

            return d.GetCantidad() - conversionDolar.GetCantidad();
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar conversionDolar = new Dolar();

            conversionDolar = (Dolar)p;

            return d.GetCantidad() - conversionDolar.GetCantidad();
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar conversionDolar = new Dolar();

            conversionDolar = (Dolar)e;

            return d.GetCantidad() + conversionDolar.GetCantidad();
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar conversionDolar = new Dolar();

            conversionDolar = (Dolar)p;

            return d.GetCantidad() + conversionDolar.GetCantidad();
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool iguales = false;

            if (d.GetCantidad() == e.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool iguales = false;

            if (d.GetCantidad() == p.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool iguales = false;

            if (d1.GetCantidad() == d2.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }



    
    }
}
