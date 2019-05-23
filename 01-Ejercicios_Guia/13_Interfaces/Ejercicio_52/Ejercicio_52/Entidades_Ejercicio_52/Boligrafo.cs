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
        //...
      }
    }

    public float UnidadesDeEscritura
    {
      get
      {
        //...
      }
      set
      {
        //...
      }
    }

    

    public EscrituraWrapper Escribir(string texto)
    {
      this.tinta = (float)0.3 * this.UnidadesDeEscritura;
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
      return base.ToString();
    }


  }
}
