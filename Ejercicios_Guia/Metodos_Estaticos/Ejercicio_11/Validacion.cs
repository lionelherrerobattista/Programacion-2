using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {

        public static bool Validar(int valor, int min, int max)
        {
            bool valido = false;

            //Compruebo que el número se encuentre dentro del rango
            if (valor <= max && valor >= min)
            {
                valido = true; //valido el número
            }

            return valido;

        }

    }
}
