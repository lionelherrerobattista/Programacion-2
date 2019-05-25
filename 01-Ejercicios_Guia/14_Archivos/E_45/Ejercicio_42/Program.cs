using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace Ejercicio_42
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Paso el path del escritorio de la máquina
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Agrego el formato requerido al nombre del archivo
            path = String.Format("{0}\\{1:yyyyMMdd-hhmm}.txt", path, DateTime.Now);

            try
            {
                OtraClase c = new OtraClase();
                
                c.MiMetodoDeInstancia();
            }
            catch (MiException e)
            {
                ArchivoTexto.Guardar(path, e.Message);

                

                if (!(e.InnerException is null))
                {
                    Exception excepcion = e.InnerException;
                   
                    do
                    {
                        ArchivoTexto.Guardar(path, excepcion.Message);
                        excepcion = excepcion.InnerException;

                    } while (!(object.ReferenceEquals(excepcion, null)));
                }

            }

            path = "lala";

            //Leo el archivo y muestro por pantalla
            try
            {
                Console.WriteLine(ArchivoTexto.Leer(path));
            }
            catch(Exception exeptionArchivo)
            {
                Console.WriteLine(exeptionArchivo);
            }

            Console.ReadKey();

            
            


        }
    }
}
