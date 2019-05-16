using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class OtraClase
    {
        //d. Luego crear un método de instancia que capture la excepción anterior.
        //Este método generará una excepción propia llamada MiException y la lanzará.
        public void MiMetodoDeInstancia()
        {
            try
            {
                new MiClase(0);
            }
            catch (UnaException e)
            {
                throw new MiException("Punto d", e);
            }
        }
    }
}
