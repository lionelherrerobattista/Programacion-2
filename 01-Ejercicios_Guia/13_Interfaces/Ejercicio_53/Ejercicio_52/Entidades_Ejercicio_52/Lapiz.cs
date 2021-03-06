using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  public class Lapiz : IAcciones
  {
    private float tamanioMina;

    public Lapiz(int unidades)
    {
      this.tamanioMina = unidades;
    }
    
    ConsoleColor IAcciones.Color
    {
      get
      {
        return ConsoleColor.Gray;
      }
      set
      {
        throw new NotImplementedException();
      }
    }

    float IAcciones.UnidadesDeEscritura
    {
      get
      {
        return this.tamanioMina;
      }
      set
      {
        this.tamanioMina = value;
      }
    }

    EscrituraWrapper IAcciones.Escribir(string texto)
    {
      EscrituraWrapper escritura;

      

      if (this.tamanioMina > 0)
      {
        escritura = new EscrituraWrapper(texto, ((IAcciones)this).Color);//Primero hay que castearlo

        ((IAcciones)this).UnidadesDeEscritura -= (float)0.1 * texto.Count();
      }
      else
      {
        escritura = new EscrituraWrapper("", ((IAcciones)this).Color);
      }

      return escritura;
    }

    bool IAcciones.Recargar(int unidades)
    {
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      string datos;

      datos = String.Format("Tipo: {0} \nColor: {1} \nNivel de tinta: {2}\n",
        "Lápiz", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);

      return datos;
    }

  }
}
