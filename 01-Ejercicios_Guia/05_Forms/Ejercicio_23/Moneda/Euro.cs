using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar = 1.16f;

        //Constructores
        private Euro()
        {
            new Euro(0);
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)//uso operador this para llamar a la función
        {
            cotizRespectoDolar = cotizacion;
        }

        //Sobrecarga operadores:
        public static explicit operator Dolar(Euro d)//Conversion Euro a Dolar
        {
            return d.GetCantidad() * Euro.GetCotizacion();
        }

        public static explicit operator Pesos(Euro d)//Para poder operar con Pesos
        {
            return (d.GetCantidad() * Euro.GetCotizacion()) * Pesos.GetCotizacion();
        }

        public static implicit operator Euro(double d)
        {
            Euro e1 = new Euro(d);

            return e1;
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
        public static bool operator !=(Euro e, Dolar d)
        {
            bool distinto = false;

            if (e.GetCantidad() != d.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            bool distinto = false;

            if (e.GetCantidad() != p.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool distinto = false;

            if (e1.GetCantidad() != e2.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro conversionEuro = new Euro();

            conversionEuro = (Euro)d;

            return e.GetCantidad() - conversionEuro.GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro conversionEuro = new Euro();

            conversionEuro = (Euro)p;

            return e.GetCantidad() - conversionEuro.GetCantidad();
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro conversionEuro = new Euro();

            conversionEuro = (Euro)d;

            return e.GetCantidad() + conversionEuro.GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro conversionEuro = new Euro();

            conversionEuro = (Euro)p;

            return e.GetCantidad() + conversionEuro.GetCantidad();
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool iguales = false;

            if (e.GetCantidad() == d.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool iguales = false;

            if (e.GetCantidad() == p.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool iguales = false;

            if (e1.GetCantidad() == e2.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

    }
}
