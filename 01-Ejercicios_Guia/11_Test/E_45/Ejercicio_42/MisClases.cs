using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase
    {
        public static void Dividir()
        {
            double resultado;
            int b = 0; 

            //a. Lanzar una excepción DivideByZeroException en un método estático
            try
            {                
                resultado = 10 / b;
            }
            catch(DivideByZeroException e)
            {

                throw e;

            }

            
        }

        //b. Capturar la excepción del punto a en un constructor de instancia
        //y relanzarla hacia otro constructor de instancia.
        public MiClase()
        {
            try
            {
                MiClase.Dividir();
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }

        }

        //c. En este segundo constructor, crear una excepción propia llamada UnaException (utilizar innerException
        //para almacenar la excepción original) y volver a lanzarla.
        public MiClase(int a)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("2do Constructor de instancia Exception", e) ;
            }

        }
    }
}
