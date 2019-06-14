using System;
using System.Threading;

namespace Entidades_Ejercicio_67
{
  public sealed class Temporalizador
  {
    private Thread hilo;
    private int intervalo;

    

    public bool Activo
    {
      get
      {
        return this.hilo.IsAlive;
      }
      set
      {

        if(this.hilo is null)
        {
          this.hilo = new Thread(Corriendo);
        }

        if(this.hilo.IsAlive == false && value == true)
        {
          this.hilo = new Thread(this.Corriendo);

          this.hilo.Start();
        }
        else
        {
          this.hilo.Abort();
        }
      }
    }

    public int Intervalo
    {
      get
      {
        return this.intervalo;
      }
      set
      {
        this.intervalo = value;
      }
    }

    private void Corriendo()
    {
      do
      {

        this.EventoTiempo.Invoke();

        Thread.Sleep(this.Intervalo);

      } while (true);
    }

    public delegate void encargadoTiempo();

    public event encargadoTiempo EventoTiempo;




  }
}
