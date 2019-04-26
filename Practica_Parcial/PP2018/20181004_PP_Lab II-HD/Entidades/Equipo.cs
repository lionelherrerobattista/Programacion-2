using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Equipo
  {
    const int cantidadMaximaJugadores = 6;
    private DirectorTecnico directorTecnico;
    private List<Jugador> jugadores;
    private string nombre;

    public DirectorTecnico DirectorTecnico
    {
      set
      {
        if(value.ValidarAptitud())
        {
          this.directorTecnico = value;
        }
        
      }
    }

    public string Nombre
    {
      get
      {
        return nombre;
      }
    }

    private Equipo()
    {
      jugadores = new List<Jugador>();

    }

    public Equipo(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static explicit operator string(Equipo e)
    {
      StringBuilder datosEquipo = new StringBuilder();

      datosEquipo.AppendFormat("Nombre: {0}\n", e.nombre);

      if(e.directorTecnico == null)
      {
        datosEquipo.AppendLine("Sin DT asignado.");
      }
      else
      {
        datosEquipo.AppendFormat("DT: {0}\n", e.directorTecnico.Mostrar());
      }

      foreach(Jugador jugador in e.jugadores)
      {
        datosEquipo.AppendLine(jugador.Mostrar());
      }

      return datosEquipo.ToString();

    }

    public static bool operator !=(Equipo e, Jugador j)
    {
      return !(e == j);
    }

    public static bool operator ==(Equipo e, Jugador j)
    {
      bool sonIguales = false;

      if(e.jugadores.Contains(j))
      {
        sonIguales = true;
      }

      return sonIguales;



    }

    public static Equipo operator +(Equipo e, Jugador j)
    {

      if(e.jugadores.Contains(j) == false)
      {
        if(e.jugadores.Count() < cantidadMaximaJugadores)
        {
          if(j.ValidarAptitud() == true)
          {
            e.jugadores.Add(j);
          }
        }
      }

      return e;
    }

    public static bool ValidarEquipo(Equipo e)
    {
      bool esValido = false;
      int contadorArqueros = 0;
      int contadorDefensor = 0;
      int contadorCentral = 0;
      int contadorDelantero = 0;

      if(!(e.directorTecnico == null))
      {
        if(e.jugadores.Count() == cantidadMaximaJugadores)
        {

          foreach(Jugador jugador in e.jugadores)
          {
            if(jugador.Posicion == Posicion.Arquero)
            {
              contadorArqueros++;
            }
            else if(jugador.Posicion == Posicion.Central)
            {
              contadorCentral++;
            }
            else if(jugador.Posicion == Posicion.Defensor)
            {
              contadorDefensor++;
            }
            else
            {
              contadorDelantero++;
            }

          }

          if(contadorArqueros == 1 && contadorCentral >= 1 && contadorDefensor >= 1
            && contadorDelantero >= 1)
          {
            esValido = true;
          }
             
        }
        
               
      }

      return esValido;

    }





  }
}
