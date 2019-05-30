using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            bool guardoArchivo = false;

            XmlTextWriter writer;
            XmlSerializer ser;

            if (this.ValidarArchivo(ruta, true))
            {
                writer = new XmlTextWriter(ruta, null);

                ser = new XmlSerializer(typeof(string));

                ser.Serialize(writer, objeto);

                writer.Close();

                guardoArchivo = true;
            }

            return guardoArchivo;



        }

        public bool GuardarComo(string ruta, string objeto)
        {
            bool guardoArchivo = false;

            XmlTextWriter writer;
            XmlSerializer ser;

            if (this.ValidarArchivo(ruta, false))
            {
                writer = new XmlTextWriter(ruta, null);

                ser = new XmlSerializer(typeof(string));

                ser.Serialize(writer, objeto);

                writer.Close();

                guardoArchivo = true;
            }

            return guardoArchivo;
        }

        public string Leer(string ruta)
        {
            string auxiliarDato = "";

            XmlTextReader reader;
            XmlSerializer ser;

            if(this.ValidarArchivo(ruta, true))
            {
                reader = new XmlTextReader(ruta);

                ser = new XmlSerializer(typeof(string));

                auxiliarDato = (string)ser.Deserialize(reader);

                reader.Close();
            }

            return auxiliarDato;
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool archivoExiste = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) == true)
                {
                    if (Path.GetExtension(ruta) == ".txt")//compruebo que la extensión coincida
                    {
                        archivoExiste = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .txt");
                    }

                }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }

            return archivoExiste;
        }


    }
}
