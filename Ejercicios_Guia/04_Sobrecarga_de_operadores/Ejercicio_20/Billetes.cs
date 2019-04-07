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

        //Conversión de Pesos a Dolares usando el operador (Dolar)
        public static explicit operator Dolar(Pesos d)
        {
            return d.GetCantidad() / Pesos.GetCotizacion();
        }

        //Conversion de Pesos a Euros usando el operador (Euro)
        public static explicit operator Euro(Pesos d)
        {
            //Lo paso a dólares primero y, después, a euros
            return (d.GetCantidad() / Pesos.GetCotizacion()) / Euro.GetCotizacion();
        }

        //Compatibilidad implícita con el mismo tipo de dato
        //para operar pesos con pesos(?)
        public static implicit operator Pesos(double d)
        {
            Pesos p1 = new Pesos(d);//le paso la cantidad

            return p1;//devuelve un objeto pesos con esa cantidad
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

        //Sobrecarga de operadores, comparo cantidades
        public static bool operator !=(Pesos p, Dolar d)
        {
            bool distinto = false;

            if (p.GetCantidad() != d.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            bool distinto = false;

            if (p.GetCantidad() != e.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool distinto = false;

            if (p1.GetCantidad() != p2.GetCantidad())
            {
                distinto = true;
            }

            return distinto;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos conversionPesos = new Pesos();//creo un objeto para poder convertir y operar

            conversionPesos = (Pesos) d;//Conversión explícita a pesos
            
            //devuelvo el resultado de la resta
            return p.GetCantidad() - conversionPesos.GetCantidad();

        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos conversionPesos = new Pesos();

            conversionPesos = (Pesos)e;

            return p.GetCantidad() - conversionPesos.GetCantidad();
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos conversionPesos = new Pesos();

            conversionPesos = (Pesos)d;

            return p.GetCantidad() + conversionPesos.GetCantidad();

        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos conversionPesos = new Pesos();

            conversionPesos = (Pesos)e;

            return e.GetCantidad() - conversionPesos.GetCantidad();
        }

        public static bool operator ==(Pesos p, Dolar d)
        {

            return !(p != d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool iguales = false;

            if (p.GetCantidad() == e.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool iguales = false;

            if (p1.GetCantidad() == p2.GetCantidad())
            {
                iguales = true;
            }

            return iguales;
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

    class Dolar
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

            if(d1.GetCantidad() != d2.GetCantidad())
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
