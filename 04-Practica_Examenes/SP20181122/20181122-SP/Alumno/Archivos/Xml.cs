using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        

           

    public void Guardar(string archivo, T datos)
    {
      string path;
     
      XmlTextWriter writer;
      XmlSerializer ser;

      path = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

      writer = new XmlTextWriter(path, Encoding.UTF8);

      ser = new XmlSerializer(typeof(T));

      ser.Serialize(writer, datos);

      writer.Close();

    }

    public void Leer(string archivo, out T datos)
    {
      string path;

      XmlTextReader reader;
      XmlSerializer ser;

      path = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

      reader = new XmlTextReader(path);

      ser = new XmlSerializer(typeof(T));

      datos = (T)ser.Deserialize(reader);

      reader.Close();

    }
  }
}
