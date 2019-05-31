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

  public class Provincial : Llamada, IGuardar<Provincial>
  {
    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3

    }

    protected Franja franjaHoraria;
    private string rutaDeArchivo;
    private float costoLlamada;

    public Provincial()
    {

    }

    public Provincial(Franja miFranja, Llamada llamada)
        : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.franjaHoraria = miFranja;



    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino)
        : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;


    }

    public override float CostoLlamada
    {
      get
      {
        return this.CalcularCosto();

      }
      set
      {
        this.costoLlamada = this.CalcularCosto();
      }
    }


    public string RutaDeArchivo
    {
      get
      {
        return this.rutaDeArchivo;
      }
      set
      {
        this.rutaDeArchivo = value;
      }

    }

    private float CalcularCosto()
    {
      float costo;

      if (this.franjaHoraria == Franja.Franja_1)
      {
        costo = this.Duracion * (float)0.99;

      }
      else if (this.franjaHoraria == Franja.Franja_2)
      {
        costo = this.Duracion * (float)1.25;
      }
      else
      {
        costo = this.Duracion * (float)0.66;
      }

      return costo;
    }

    public bool Guardar()
    {
      string path;
      bool guardoArchivo = false;

      XmlTextWriter writer;
      XmlSerializer ser;

      path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      path = String.Format("{0}\\Llamadas\\Provincial.xml", path);

      this.RutaDeArchivo = path;

      writer = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8);

      ser = new XmlSerializer(typeof(Provincial));

      //guardo los datos de la clase
      ser.Serialize(writer, this);

      writer.Close();

      if (File.Exists(this.RutaDeArchivo))
      {
        guardoArchivo = true;

      }

      return guardoArchivo;

    }

    public Provincial Leer()
    {
      Provincial auxiliarProvincial;

      XmlTextReader reader;
      XmlSerializer ser;

      reader = new XmlTextReader(this.RutaDeArchivo);

      ser = new XmlSerializer(typeof(Provincial));

      auxiliarProvincial = (Provincial)ser.Deserialize(reader);

      reader.Close();

      if (auxiliarProvincial is Provincial)
      {
        return auxiliarProvincial;
      }
      else
      {
        throw new InvalidCastException();
      }

    }



    protected override string Mostrar()
    {
      StringBuilder datos = new StringBuilder();

      datos.AppendFormat("{0}", base.Mostrar());
      datos.AppendFormat(" {0,-15}", this.CostoLlamada);

      return datos.ToString();

    }

    public override bool Equals(object obj)
    {
      bool esProvincial = false;

      if (obj is Provincial)
      {
        esProvincial = true;
      }

      return esProvincial;

    }

    public override string ToString()
    {
      return this.Mostrar();
    }

  }
}
