using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
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

        public Pesos(double cantidad, float cotizacion) : this(cantidad)//uso operador this para llamar a la función
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

            conversionPesos = (Pesos)d;//Conversión explícita a pesos

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
}
