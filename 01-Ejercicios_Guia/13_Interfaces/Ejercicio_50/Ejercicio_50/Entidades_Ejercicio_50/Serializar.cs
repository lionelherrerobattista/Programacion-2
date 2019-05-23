using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_50
{
  public class Serializar <S, V> : IGuardar <S, V>
  {   

    public bool Guardar(S obj)
    {
      return true;
    }

    public V Leer()
    {
      string mensaje = "Objeto leido";

      return (V)Convert.ChangeType(mensaje, typeof(V));
    }
  }
}
