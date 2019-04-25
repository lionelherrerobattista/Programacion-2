using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    public class AutoF1
    {

        private short catidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.catidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;

        }

        public string MostrarDatos()
        {

            return String.Format("{0} {1} {2} {3}", this.catidadCombustible, this.escuderia, this.numero, this.vueltasRestantes);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            bool sonDistintos = false;

            if(a1.numero != a2.numero && a1.escuderia != a2.escuderia)
            {
              sonDistintos = true;
            }

            return sonDistintos;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
          return !(a1 != a2);

        }


    }
}
