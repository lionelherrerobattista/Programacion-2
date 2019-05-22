using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_50
{
  public class Serializar <S, V>
  {
    bool Guardar(S obj)
    {
      return true;
    }

    V Leer()
    {
      string mensaje = "objeto leido";

      return (V)Convert.ChangeType(mensaje, typeof(V));
    }
  }
}
