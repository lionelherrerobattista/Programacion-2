using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio_52;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      bool resultado = true;

      ConsoleColor colorOriginal = Console.ForegroundColor;
      Cartuchera1 cUno = new Cartuchera1();
      Cartuchera2 cDos = new Cartuchera2();
      Lapiz miLapiz = new Lapiz(3);
      Boligrafo miBoligrafo = new Boligrafo(3, ConsoleColor.Green);


      cUno.lista.Add(miLapiz);
      cUno.lista.Add(miBoligrafo);

      cDos.listaBoligrafos.Add(miBoligrafo);
      cDos.listaLapices.Add(miLapiz);

      Console.WriteLine("Pruebo elementos Cartuchera1:");
      do
      {
        resultado = cUno.ProbarElementos();

      } while (resultado == true);

      resultado = true;

      Console.WriteLine("");

      Console.WriteLine("Pruebo elementos Cartuchera2: ");

      do
      {


        resultado = cDos.ProbarElementos();

      } while (resultado == true);

      Console.WriteLine("");
      Console.WriteLine("Termino.");
       

      /*
      Lapiz miLapiz = new Lapiz(10);
      Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

  
      EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
      Console.ForegroundColor = eLapiz.color;
      Console.WriteLine(eLapiz.texto);
      Console.ForegroundColor = colorOriginal;
      Console.WriteLine(miLapiz);

      EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
      Console.ForegroundColor = eBoligrafo.color;
      Console.WriteLine(eBoligrafo.texto);
      Console.ForegroundColor = colorOriginal;
      Console.WriteLine(miBoligrafo);
      */
      Console.ReadKey();
    }
  }
}
