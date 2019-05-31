using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  public class Cartuchera2
  {
    public List<Lapiz> listaLapices;
    public List<Boligrafo> listaBoligrafos;

    public Cartuchera2()
    {
      this.listaLapices = new List<Lapiz>();
      this.listaBoligrafos = new List<Boligrafo>();
    }

    public bool ProbarElementos()
    {

      
      string texto;

      EscrituraWrapper elemento;

      foreach(Lapiz l in listaLapices)
      {
        //tomo el elemento
        elemento = ((IAcciones)(l)).Escribir("*");

        texto = elemento.texto;

        //escribo
        Console.WriteLine(texto);

        if (texto.Count() == 0)
        {
          return false;
          
        }

        
      }

      Console.WriteLine("");

      foreach(Boligrafo b in listaBoligrafos)
      {
        //tomo el elemento

        
        elemento = b.Escribir("*");
        Console.ForegroundColor = elemento.color;

        texto = elemento.texto;

        //escribo
        Console.Write(texto);

        if (texto.Count() == 0)
        {
          return false;

        }

        

      }

      Console.ForegroundColor = colorOriginal;

      return true;

    }

  }
}
