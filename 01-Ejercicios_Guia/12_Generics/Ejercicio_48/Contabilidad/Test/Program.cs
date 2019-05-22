using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio_48;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Contabilidad<Factura, Recibo> estudio;
      Recibo reciboUno;
      Recibo reciboDos;
      Factura facturaUno;

      estudio = new Contabilidad<Factura, Recibo>();

      reciboUno = new Recibo(10);
      reciboDos = new Recibo();
      facturaUno = new Factura(2);

      //Agrego
      estudio += facturaUno;
      estudio += reciboUno;
      estudio += reciboDos;

      //Muestro
      foreach(Documento d in estudio.Egresos)
      {
        Console.WriteLine(d.Numero);
      }

      foreach(Documento d in estudio.Ingresos)
      {
        Console.WriteLine(d.Numero);
      }

      Console.ReadKey();
      


    }
  }
}
