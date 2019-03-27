using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool valido = false;

            //Comparo si el usuario ingresó una s
            if (Char.ToUpper(c) == 'S')
            {
                valido = true;
            }

            return valido;
        }

    }
}
