using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComiqueriaLogic
{
    public static class Serializador<T> where T : class, new()
    {
        /// <summary>
        /// Permite serializar a binario
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static bool GuardarBinario(string ruta, T dato)
        {
            bool guardoArchivo = true;



            FileStream fs;
            BinaryFormatter ser;


            try
            {

                fs = new FileStream(ruta, FileMode.Create);

                ser = new BinaryFormatter();

                ser.Serialize(fs, dato);

                fs.Close();

            }
            catch(DirectoryNotFoundException e)
            {
                guardoArchivo = false;

                ComiqueriaException comiqueriaException = new ComiqueriaException("Error: Directorio no encontrado.", e);

                ArchivoTexto.Escribir(comiqueriaException, true);

                throw comiqueriaException;

                
            }

            return guardoArchivo;
        }

        public static bool LeerBinario(string ruta, out T dato)
        {


            bool leyo = true;

            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = String.Format("{0}\\comiqueria.dat", ruta);

            try
            {

                FileStream fs;
                BinaryFormatter ser;

                fs = new FileStream(ruta, FileMode.Open);

                ser = new BinaryFormatter();

                dato = (T)ser.Deserialize(fs);

                fs.Close();
            }
            catch(Exception e)
            {
                leyo = false;
                dato = null;

                throw new Exception("Ocurrio un error, contacte al administrador", e);
            }

            return leyo;
        }


        public static bool GuardarXML(string path, T dato)
        {
            
            bool guardoArchivo = false;

            XmlTextWriter writer;
            XmlSerializer ser;

            try
            {
                

                writer = new XmlTextWriter(path, Encoding.UTF8);

                ser = new XmlSerializer(typeof(T));

                //guardo los datos de la clase
                ser.Serialize(writer, dato);

                writer.Close();
            }
            catch
            {
                guardoArchivo = false;
            }



            return guardoArchivo;

        }

        public static bool LeerXml(string ruta, out T dato)
        {
            bool leyoArchivo = true;

            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(ruta);

                ser = new XmlSerializer(typeof(T));

                dato = (T)ser.Deserialize(reader);

                reader.Close();
            }
            catch(ArgumentException argException)
            {
                leyoArchivo = false;
                dato = null;

                throw argException;

            }


            return leyoArchivo;

        }
    }
}
