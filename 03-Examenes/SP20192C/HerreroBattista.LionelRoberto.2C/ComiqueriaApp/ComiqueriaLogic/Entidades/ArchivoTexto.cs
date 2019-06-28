using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic
{
    public static class ArchivoTexto
    {

        public static bool Escribir(IArchivoTexto objeto, bool append)
        {
            bool escribio = true;

            try
            {
                StreamWriter sw = new StreamWriter(objeto.Ruta, append);

                sw.WriteLine(objeto.Texto);

                sw.Close();
            }
            catch (Exception e)
            {
                escribio = false;

                throw e;
            }


            return escribio;
        }

        public static string Leer(string path)
        {
            string datos;

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                datos = sr.ReadToEnd();

                sr.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }

            return datos;

        }
    }
}
