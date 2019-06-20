using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeExtensionString
{
    public static class StringExtension
    {
        public static int CantidadSignosPuntuacion(this string texto)
        {
            int contadorSignos = 0;

            foreach(char c in texto)
            {
                if(c == '.' || c == ',' || c == ';')
                {
                    contadorSignos++;
                }
            }

            return contadorSignos;
        }

    }
}
