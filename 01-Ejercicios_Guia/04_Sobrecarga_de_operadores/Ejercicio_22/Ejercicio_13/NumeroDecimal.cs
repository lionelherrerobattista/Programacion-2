using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static explicit operator double(NumeroDecimal objDecimal)
        {
            return objDecimal.numero;
        }

        public static implicit operator NumeroDecimal(double objDecimal)
        {
            return new NumeroDecimal(objDecimal);
        }


        public static double operator +(NumeroDecimal objDecimal, NumeroBinario objBinario)
        {
            double resultado;

            resultado = (double)objDecimal + Conversor.BinarioDecimal((string)objBinario);

            return resultado;
        }

        public static double operator -(NumeroDecimal objDecimal, NumeroBinario objBinario)
        {
            double resultado;

            resultado = (double)objDecimal - Conversor.BinarioDecimal((string)objBinario);

            return resultado;
        }

        public static bool operator ==(NumeroDecimal objDecimal, NumeroBinario objBinario)
        {
            bool sonIguales = false;

            if ((double)objDecimal == Conversor.BinarioDecimal((string)objBinario))
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(NumeroDecimal objDecimal, NumeroBinario objBinario)
        {
            return !(objDecimal == objBinario);
        }
    }
}
