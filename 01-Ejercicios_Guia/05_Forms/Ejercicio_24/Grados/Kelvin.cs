using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Kelvin
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
            return new Fahrenheit(k.GetGrados() / (5 / 9d) - 459.67);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.GetGrados() - 273.15);
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
            return new Kelvin(grados);
        }

    }
}
