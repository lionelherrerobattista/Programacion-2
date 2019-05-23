using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_50
{
  public class GuardarTexto<T, V> : IGuardar<T, V>
  {
    public bool Guardar(T obj)
    {
      return true;
    }

    public V Leer()
    {
      string mensaje = "Texto leido";

      return (V)Convert.ChangeType(mensaje, typeof(V));
    }
  }
}
