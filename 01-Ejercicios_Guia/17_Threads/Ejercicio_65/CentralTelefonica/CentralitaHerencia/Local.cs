using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace CentralitaHerencia
{
  public class Local : Llamada, IGuardar<Local>
  {
    protected float costo;
    private float costoLlamada;
    private string rutadeArchivo;

    public Local()
    {

    }

    public Local(Llamada llamada, float costo)
        : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.costo = costo;
      

    }

    public Local(string origen, float duracion, string destino, float costo)
        : base(duracion, destino, origen)
    {
      this.costo = costo;

    }

    public float Costo
    {
      get
      {
        return this.costo;
      }
      set
      {
        this.costo = value;
      }
    }

    public override float CostoLlamada
    {
      get
      {
        return this.CalcularCosto();
      }
      set
      {
        this.costoLlamada = value;
      }
    }

    public string RutaDeArchivo
    {
      get
      {
        return this.rutadeArchivo;
      }
      set
      {
        this.rutadeArchivo = value;
      }

    }

    private float CalcularCosto()
    {
      float valor;

      valor = this.Duracion * (float)this.Costo;

      return valor;

    }

    public bool Guardar()
    {
      string path;
      bool guardoArchivo = false;

      XmlTextWriter writer;
      XmlSerializer ser;

      
      path = "Local.xml";

      this.RutaDeArchivo = path;

      writer = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8);

      ser = new XmlSerializer(typeof(Local));

      //guardo los datos de la clase
      ser.Serialize(writer, this);
      
      writer.Close();

      if(File.Exists(this.RutaDeArchivo))
      {
        guardoArchivo = true;

      }

      return guardoArchivo;

    }

    public Local Leer()
    {
      Local auxiliarLocal;

      XmlTextReader reader;
      XmlSerializer ser;

      reader = new XmlTextReader(this.RutaDeArchivo);

      ser = new XmlSerializer(typeof(Local));

      auxiliarLocal = (Local)ser.Deserialize(reader);

      reader.Close();

      if(auxiliarLocal is Local)
      {
        return auxiliarLocal;
      }
      else
      {
        throw new InvalidCastException();
      }

    }

    protected override string Mostrar()
    {
      StringBuilder datos = new StringBuilder();

      this.CostoLlamada = this.CalcularCosto();

      datos.AppendFormat("{0}", base.Mostrar());
      datos.AppendFormat(" {0,-15}", this.CostoLlamada);

      return datos.ToString();
    }

    public override bool Equals(object obj)
    {
      bool esLocal = false;

      if (obj is Local)
      {
        esLocal = true;
      }

      return esLocal;
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
