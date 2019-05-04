using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_38
{
    public class Sobreescrito : Object
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        
        public override bool Equals(object obj)
        {
            bool sonIguales = false;

            if (obj is Sobreescrito)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
