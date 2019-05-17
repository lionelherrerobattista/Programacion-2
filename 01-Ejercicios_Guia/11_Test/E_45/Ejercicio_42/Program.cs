using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                OtraClase c = new OtraClase();
                
                c.MiMetodoDeInstancia();
            }
            catch (MiException e)
            {
                Console.WriteLine(e.Message);

                

                if (!(e.InnerException is null))
                {
                    Exception excepcion = e.InnerException;
                   
                    do
                    {
                        Console.WriteLine(excepcion.Message);
                        excepcion = excepcion.InnerException;

                    } while (!(object.ReferenceEquals(excepcion, null)));
                }
                


            }

            Console.ReadKey();

            
            


        }
    }
}
