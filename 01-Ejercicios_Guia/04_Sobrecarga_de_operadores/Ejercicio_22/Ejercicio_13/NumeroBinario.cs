using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static explicit operator string(NumeroBinario objBinario)
        {
            return objBinario.numero;
        }

        public static implicit operator NumeroBinario(string objBinario)
        {
            return new NumeroBinario(objBinario);
        }


        public static string operator +(NumeroBinario objBinario, NumeroDecimal objDecimal)
        {
            double resultado;

            resultado =  Conversor.BinarioDecimal((string)objBinario) + (double)objDecimal;

            return Conversor.DecimalBinario(resultado);           
        }

        public static string operator -(NumeroBinario objBinario, NumeroDecimal objDecimal)
        {
            double resultado;

            resultado = Conversor.BinarioDecimal((string)objBinario) - (double)objDecimal;

            return Conversor.DecimalBinario(resultado);
        }

        public static bool operator ==(NumeroBinario objBinario, NumeroDecimal objDecimal)
        {
            bool sonIguales = false;

            if(Conversor.BinarioDecimal((string)objBinario) == (double)objDecimal)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(NumeroBinario objBinario, NumeroDecimal objDecimal)
        {
            return !(objBinario == objDecimal);
        }
    }
}
