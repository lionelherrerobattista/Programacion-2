using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string info)
        {
            StreamWriter sw = new StreamWriter(path, true);

            sw.WriteLine(info);

            sw.Close();
        }

        public static string Leer(string path)
        {
            string datos;

            if(File.Exists(path))
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
