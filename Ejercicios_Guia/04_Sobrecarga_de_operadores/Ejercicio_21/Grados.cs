using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    class Fahrenheit
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
            return (f.GetGrados() - 32) / (9/5);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return (f.GetGrados() + 459.67) / (9/5) ;
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
            return (Fahrenheit)grados;
        }

        
        //Sobrecarga de operadores
        //
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            bool esDistinto = false;

            if(f.GetGrados() != c.GetGrados())
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

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            Fahrenheit conversionFahrenheit = new Fahrenheit();

            conversionFahrenheit = (Fahrenheit)c;


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

    class Celsius
    {

        private double grados;

        //Constructores
        //

        private Celsius()
        {

        }

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        //
        //Conversiones explícitas
        public static explicit operator Fahrenheit(Celsius c)
        {
            return  c.GetGrados() * (9 / 5) + 32;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return c.GetGrados() + 273.15;
        }

        //Getters
        //
        public double GetGrados()
        {
            return this.grados;
        }

        //Conversion implícita
        //
        public static implicit operator Celsius(double grados)
        {
            return (Celsius)grados;
        }

    }

    class Kelvin
    {

        private double grados;



        //Constructores
        //

        private Kelvin()
        {

        }

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        //Conversiones explícitas
        //
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return k.GetGrados() / (5 / 9) - 459.67;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return k.GetGrados() - 273.15;
        }

        //Getters
        //
        public double GetGrados()
        {
            return this.grados;
        }

        //Conversion implícita
        //
        public static implicit operator Kelvin(double grados)
        {
            return (Kelvin)grados;
        }

    }
}
