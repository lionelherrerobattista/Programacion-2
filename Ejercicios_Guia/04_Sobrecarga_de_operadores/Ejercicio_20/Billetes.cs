using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar = 38.33f;

        //Constructores
        private Pesos()
        {
            new Pesos(0);
            
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion): this(cantidad)//uso operador this para llamar a la función
        {
            cotizRespectoDolar = cotizacion;
        }

        //Sobrecarga tipos de datos (compatibilidad distintos tipos de datos):
        public static explicit operator Dolar(Pesos d)//Para poder operar con Dolar
        {
            return (Dolar)d;
        }

        public static explicit operator Euro(Pesos d)//Para poder operar con Pesos
        {
            return (Euro)d;
        }

        //Compatibilidad implícita con el mismo tipo de dato
        //para operar pesos con pesos(?)
        public static implicit operator Pesos(double d)
        {
            return (Pesos)d;
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
    }

    class Euro
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

        //Sobrecarga operadores (compatibilidad distintos tipos de datos):
        public static explicit operator Dolar(Euro d)//Para poder operar con Dolar
        {
            return (Dolar)d;
        }

        public static explicit operator Pesos(Euro d)//Para poder operar con Pesos
        {
            return (Pesos)d;
        }

        public static implicit operator Euro(double d)
        {
            return (Euro)d;
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

    }

    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar = 1;

        //Constructores
        private Dolar()
        {
            new Euro(0);
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
            return (Euro)d;
        }

        public static explicit operator Pesos(Dolar d)//Para poder operar con Pesos
        {
            return (Pesos)d;
        }

        public static implicit operator Dolar(double d)
        {
            return (Dolar)d;
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

    }

}
