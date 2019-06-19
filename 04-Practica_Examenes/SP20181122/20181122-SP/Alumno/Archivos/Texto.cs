using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
  public class Texto : IArchivo<Queue<Patente>>
  {



    public void Guardar(string archivo, Queue<Patente> datos)
    {
      string path;

      path = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

      try
      {
        StreamWriter sw = new StreamWriter(path);

        foreach (Patente patente in datos)
        {
          sw.WriteLine(patente);
        }

        sw.Close();
      }
      catch (Exception e)
      {
        throw e;
      }



    }

    public void Leer(string archivo, out Queue<Patente> datos)
    {
      string path;
      string auxDatos;
      Queue<Patente> patentes;
      Patente auxPatente;

      path = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);

      patentes = new Queue<Patente>();


      StreamReader sr = new StreamReader(path);

      do
      {
        auxPatente = new Patente();

        auxDatos = sr.ReadLine();

        auxPatente.CodigoPatente = auxDatos;

        patentes.Enqueue(auxPatente);

      } while (auxDatos != "");

      datos = patentes;

      sr.Close();


    }
  }
}


