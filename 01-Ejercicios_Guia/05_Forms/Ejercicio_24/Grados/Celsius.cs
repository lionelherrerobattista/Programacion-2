﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Celsius
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
            return new Fahrenheit(c.GetGrados() * (9 / 5d) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.GetGrados() + 273.15);
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
            return new Celsius(grados);
        }
    }
}
