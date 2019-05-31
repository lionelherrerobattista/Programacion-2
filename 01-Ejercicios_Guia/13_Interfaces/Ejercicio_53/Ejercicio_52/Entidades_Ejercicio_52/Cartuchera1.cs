using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  public class Cartuchera1
  {
    public List<IAcciones> lista;

    public Cartuchera1()
    {
      this.lista = new List<IAcciones>();
    }

    public bool ProbarElementos()
    {
      
      string texto;

      EscrituraWrapper elemento;

      foreach (IAcciones e in this.lista)
      {
        

        //tomo el elemento
        elemento = e.Escribir("*");

        texto = elemento.texto;

        //escribo
        Console.Write(texto);

        if (texto.Count() == 0)
        {

          return false;
          
        }

      }

      return true;

    }


  }
}
