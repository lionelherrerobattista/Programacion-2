using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeExtensionString
{
    public static class ExtensionString
    {
        public static string FormatoTabla (this string cadena, int espacios)
        {
            int i;
            string nuevaCadena = "";

            for(i = 0; i <= Math.Abs(espacios); i++)
            {
                if(espacios < 0)
                {
                    nuevaCadena = cadena;
                }
                else
                {
                    nuevaCadena += " ";

                    if(i == Math.Abs(espacios))
                    {
                        nuevaCadena += cadena;
                    }
                }
            }

            return nuevaCadena;

            

            return cadena;
        }
    }
}
