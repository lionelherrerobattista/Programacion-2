using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_36
{
  public class CompetenciaNoDisponibleException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;

    public string NombreClase
    {
      get
      {
        return this.nombreClase;
      }
    }

    public string NombreMetodo
    {
      get
      {
        return this.nombreMetodo;
      }
    }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
        : base(mensaje)
    {
      this.nombreClase = clase;
      this.nombreMetodo = metodo;
    }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
        : base(mensaje, innerException)
    {
      this.nombreClase = clase;
      this.nombreMetodo = metodo;
    }

    public override string ToString()
    {
      Exception auxException;
      StringBuilder mensaje = new StringBuilder();

      mensaje.AppendFormat("Excepción en el método {0} de la clase {1}:\n", this.NombreMetodo, this.NombreClase);
      mensaje.AppendFormat("{0}\n", this.Message);

      if (!(object.ReferenceEquals(this.InnerException, null)))
      {

        auxException = this.InnerException;

        do
        {

          mensaje.AppendFormat("{0}\t", auxException.ToString());

          auxException = auxException.InnerException;

        } while (!(object.ReferenceEquals(auxException, null)));

      }

      return mensaje.ToString();
    }

  }
}
