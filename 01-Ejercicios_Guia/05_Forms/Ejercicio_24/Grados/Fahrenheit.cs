using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Fahrenheit
    {

        private double grados;

        //Constructores
        //

        private Fahrenheit()
        {

        }

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }


        //Conversiones explícitas
        //
        public static explicit operator Celsius(Fahrenheit f)
        {
            //Pasar uno a double
            return new Celsius(((f.GetGrados() - 32) * (5 / 9d)));
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            //Pasar un numero de la división a double
            return new Kelvin((f.GetGrados() + 459.67) / (9 / 5d));
        }

        //Getters
        //
        public double GetGrados()
        {
            return this.grados;
        }


        //Conversion implícita
        //
        public static implicit operator Fahrenheit(double grados)
        {
            //Creo un nuevo objeto
            return new Fahrenheit(grados);
        }


        //Sobrecarga de operadores
        //
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            bool esDistinto = false;

            if (f.GetGrados() != c.GetGrados())
            {
                esDistinto = true;
            }

            return esDistinto;

        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            bool esDistinto = false;

            if (f.GetGrados() != k.GetGrados())
            {
                esDistinto = true;
            }

            return esDistinto;

        }


        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return !(f != c);//hago funcionar al != al revés
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return !(f != k);
        }


    }
}
