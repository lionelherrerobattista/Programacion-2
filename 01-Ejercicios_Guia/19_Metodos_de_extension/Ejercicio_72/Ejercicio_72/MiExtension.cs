using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeExtension
{
    public static class MiExtension
    {
        public static int CantidadDeDigitos(this long numero)
        {
            int cantidadDigitos;

            return cantidadDigitos = numero.ToString().Length;

        }
    }
}
