using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class Competencia
    {

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
        {    
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

    public static bool operator +(Competencia c, AutoF1 a)
    {
        bool agregoCompetidor = false;

        if(c.competidores.Count < c.cantidadCompetidores && c == a)
        {
            c.competidores.Add(a);
            agregoCompetidor = true;
        }

        return agregoCompetidor;
    }

    public static bool operator ==(Competencia c, AutoF1 a)
    {

        int i;

        bool sonIguales = false;

        for(i = 0; i < c.competidores.Count; i++)
        {

          if (c.competidores[i] == a)
          {
              sonIguales = true;

          }

        }

        return sonIguales;

    }

    public static bool operator !=(Competencia c, AutoF1 a)
    {
        return !(c == a);
    }


    }
}
