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
            this.numero = numero;
            this.escuderia = escuderia;

            this.SetEnCompetencia(false);
            this.SetCombustible(0);
            this.SetVueltasRestantes(0);
        }

        public short GetCombustible()
        {
            return this.catidadCombustible;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetCombustible(short cantidadCombustible)
        {
             this.catidadCombustible = cantidadCombustible;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public string MostrarDatos()
        {
            
            return String.Format("{0,-10} {1,-10} {2,-10} {3,-10}", this.numero, this.escuderia, this.GetVueltasRestantes(), this.GetCombustible());
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
