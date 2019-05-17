using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_36
{
  public class Competencia
  {

    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<VehiculoDeCarrera> competidores;
    private TipoCompetencia tipo;

    public short CantidadCompetidores
    {
      get
      {
        return this.cantidadCompetidores;

      }
      set
      {
        this.cantidadCompetidores = value;

      }
    }

    public short CantidadVueltas
    {
      get
      {
        return this.cantidadVueltas;
      }
      set
      {
        this.cantidadVueltas = value;
      }
    }

    public VehiculoDeCarrera this[int i]
    {
      get
      {
        return this[i];
      }
    }

    public TipoCompetencia Tipo
    {
      get
      {
        return this.tipo;
      }
      set
      {
        this.tipo = value;
      }
    }

    private Competencia()
    {
      this.competidores = new List<VehiculoDeCarrera>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
    {
      this.CantidadVueltas = cantidadVueltas;
      this.CantidadCompetidores = cantidadCompetidores;
      this.Tipo = tipo;
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
    {
      bool agregoCompetidor = false;

      Random r = new Random();

      try
      {

        if (c.competidores.Count < c.cantidadCompetidores && c != a)
        {
          if (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross)
          {
            c.competidores.Add(a);
            c.competidores[c.competidores.IndexOf(a)].EnCompetencia = true;
            c.competidores[c.competidores.IndexOf(a)].VueltasRestantes = c.cantidadVueltas;
            c.competidores[c.competidores.IndexOf(a)].CantidadCombustible = (short)r.Next(15, 101);

            agregoCompetidor = true;



          }

          if (c.Tipo == TipoCompetencia.F1 && a is AutoF1)
          {

            c.competidores.Add(a);
            c.competidores[c.competidores.IndexOf(a)].EnCompetencia = true;
            c.competidores[c.competidores.IndexOf(a)].VueltasRestantes = c.cantidadVueltas;
            c.competidores[c.competidores.IndexOf(a)].CantidadCombustible = (short)r.Next(15, 101);

            agregoCompetidor = true;


          }

        }
      }
      catch (CompetenciaNoDisponibleException e)
      {
        throw new CompetenciaNoDisponibleException("Competencia incorrecta",
          "VehiculoYaAgregado", "Operator +", e);
      }


      return agregoCompetidor;
    }

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {

      int i;

      bool sonIguales = false;

      for (i = 0; i < c.competidores.Count; i++)
      {

        if (c.competidores[i] == a)
        {
          sonIguales = true;

        }
        else
        {
          throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia",
            "Vehiculo", "operator ==");

        }

      }

      return sonIguales;

    }

    public static bool operator !=(Competencia c, VehiculoDeCarrera a)
    {
      return !(c == a);
    }


  }
}
