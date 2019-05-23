using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  public class Boligrafo : IAcciones
  {
    private ConsoleColor colorTinta;
    private float tinta;

    public Boligrafo(int unidades, ConsoleColor color)
    {
      this.colorTinta = color;
      this.tinta = unidades;
    }

    public ConsoleColor Color
    {
      get
      {
        return this.colorTinta;
      }
      set
      {
        this.colorTinta = value;
      }
    }

    public float UnidadesDeEscritura
    {
      get
      {
        return this.tinta;
      }
      set
      {
        this.tinta = value;
      }
    }

    

    public EscrituraWrapper Escribir(string texto)
    {
      EscrituraWrapper escritura;

      escritura = new EscrituraWrapper(texto, this.Color);

      this.UnidadesDeEscritura -= (float)0.3 * texto.Count();

      return escritura;
      
    }

    public bool Recargar(int unidades)
    {
      bool cargoTinta = false;

      this.tinta += unidades;

      cargoTinta = true;

      return cargoTinta;
    }

    public override string ToString()
    {
      string datos;

      datos = String.Format("Tipo:{0} Color:{1} Nivel de tinta:{2}", "Boligrafo", this.Color, this.UnidadesDeEscritura);

      return datos;
    }


  }
}
