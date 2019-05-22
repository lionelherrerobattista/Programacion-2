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
      Factura facturaUno;

      estudio = new Contabilidad<Factura, Recibo>();

      reciboUno = new Recibo(10);
      facturaUno = new Factura(2);

      estudio += facturaUno;
      estudio += reciboUno;

      


    }
  }
}
