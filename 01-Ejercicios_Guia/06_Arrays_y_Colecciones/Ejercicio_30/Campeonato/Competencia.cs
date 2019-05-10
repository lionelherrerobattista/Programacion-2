using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    public class Competencia
    {

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {    
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

    public static bool operator +(Competencia c, AutoF1 a)
    {
        bool agregoCompetidor = false;

            Random r = new Random();

        if(c.competidores.Count < c.cantidadCompetidores && c != a)
        {

                c.competidores.Add(a);
                c.competidores[c.competidores.IndexOf(a)].SetEnCompetencia(true);
                c.competidores[c.competidores.IndexOf(a)].SetVueltasRestantes(c.cantidadVueltas);
                c.competidores[c.competidores.IndexOf(a)].SetCombustible((short)r.Next(15,101));

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
