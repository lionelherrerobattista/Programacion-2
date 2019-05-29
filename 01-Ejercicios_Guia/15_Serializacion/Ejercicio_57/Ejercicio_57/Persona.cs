using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_57
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static string Guardar(Persona p)
        {

            string path;

            FileStream fs;
            BinaryFormatter ser;

            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = String.Format("{0}\\archivoBinario.bin", path);

            fs = new FileStream(path, FileMode.Create);

            ser = new BinaryFormatter();

            ser.Serialize(fs, p);

            fs.Close();

            return path;
        }

        public static Persona Leer(string path)
        {
            Persona auxPersona;
            FileStream fs;
            BinaryFormatter des;

            fs = new FileStream(path, FileMode.Open);

            des = new BinaryFormatter();

            auxPersona = (Persona)des.Deserialize(fs);

            fs.Close();

            return auxPersona;
        }

        /*XML solo si son atributos públicos
        public static string Guardar(Persona p)
        {
            XmlTextWriter writer;
            XmlSerializer ser;
            string path;

            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = String.Format("{0}\\ArchivoXml.xml", path);

            writer = new XmlTextWriter(path, null);

            try
            {
                ser = new XmlSerializer(typeof(Persona));
                ser.Serialize(writer, p);
            }
            catch(InvalidOperationException exception1)
            {
                
            }
            
            writer.Close();

            return path;
        }

        public static Persona Leer(string path)
        {
            Persona auxPersona;
            XmlTextReader reader;
            XmlSerializer ser;

            reader = new XmlTextReader(path);

            ser = new XmlSerializer(typeof(Persona));

            auxPersona = (Persona)ser.Deserialize(reader);

            reader.Close();

            return auxPersona;

        }*/

        public override string ToString()
        {
            string datos;

            datos = String.Format("Nombre: {0}\n", this.nombre);
            datos = String.Format("{0}Apellido: {1}", datos, this.apellido);

            return datos;

            
        }
    }
}
