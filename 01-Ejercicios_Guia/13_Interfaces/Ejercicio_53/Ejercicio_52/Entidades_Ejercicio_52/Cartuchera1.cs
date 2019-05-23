using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_52
{
  class Cartuchera1
  {
    private List<IAcciones> lista;

    public bool ProbarElementos()
    {
      foreach(IAcciones e in lista)
      {
        e.Escribir("0");
      }
    }


  }
}
