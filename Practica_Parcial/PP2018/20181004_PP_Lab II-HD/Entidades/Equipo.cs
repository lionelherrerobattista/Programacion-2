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
      StringBuilder datos = new StringBuilder();

      return datos.ToString();

    }





  }
}
