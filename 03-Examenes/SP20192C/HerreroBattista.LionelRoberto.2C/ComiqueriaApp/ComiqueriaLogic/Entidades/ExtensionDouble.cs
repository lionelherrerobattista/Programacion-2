using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeExtension
{
    public static class ExtensionDouble
    {
        public static string FormatearPrecio(this double numero)
        {
            return String.Format("${0:#.00}", numero.ToString());

        }
    }
}
