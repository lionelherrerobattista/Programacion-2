using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool archivoValido = true;

            if(validaExistencia)
            {
                archivoValido = File.Exists(ruta);

                if (archivoValido == false)
                {
                    throw new FileNotFoundException();
                }

            }

            return archivoValido;
        }

    }
}
