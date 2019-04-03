using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        
        public static explicit operator int (Sumador s)
        {
            return (int)s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool sumasIguales = false;

            //Compruebo si las sumas son iguales
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                sumasIguales = true;
            }

            return sumasIguales;

        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;

            //Sumo la cantidad de sumas
            resultado = s1.cantidadSumas + s2.cantidadSumas;

            return resultado;
        }

        //Constructores sobrecargados:

        public Sumador()
        {
            //Reutilizo el código para inicializar en 0
            new Sumador(0);

        }

        public Sumador(int cantidadSumas)
        {
            //Incializo con el valor recibido
            this.cantidadSumas = cantidadSumas;            
        }

        //Metodos Sumar sobrecargados:

        public long Sumar(long a, long b)
        {
            long resultado;

            //Incremento cantidad de sumas en 1
            this.cantidadSumas++;

            //adiciono los parámetros
            resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            string resultado;

            //Incremento cantidad de sumas en 1
            this.cantidadSumas++;

            //Concateno las cadenas
            resultado = String.Concat(a, b);

            return resultado;

        }


    }
}
