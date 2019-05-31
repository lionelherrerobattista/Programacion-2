using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  class Cartuchera1
  {
    public List<IAcciones> lista;

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
        Console.WriteLine(texto);

        if(texto.Count() > 0)
        {
          return true;
        }
        else//si no escribio
        {
          //recargo antes de salir
          e.Recargar(1);

          return false;
        }
      }

   
    }


  }
}
