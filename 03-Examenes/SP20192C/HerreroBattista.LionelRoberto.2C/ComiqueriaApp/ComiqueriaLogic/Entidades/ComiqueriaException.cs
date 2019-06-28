using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public string Ruta
        {
            get
            {
                string datos;

                datos = DateTime.Now.ToString();

                if (!(this.InnerException is null))
                {
                    Exception excepcion = this.InnerException;

                    

                    do
                    {
                        datos = String.Format("{0}\n {1}", datos, this.InnerException);

                        excepcion = excepcion.InnerException;

                    } while (!(object.ReferenceEquals(excepcion, null)));
                }

                return datos; 
            }
        }

        public string Texto
        {
            get
            {
                return String.Format("{0}\\log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }
        }

        public ComiqueriaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
