using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
               

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {



        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
            
        }

  
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0,5} {1,15} {2,15} ", this.CantidadCombustible, this.EnCompetencia, this.Escuderia);
            datos.AppendFormat("{0,15} {1,15} {2,15}", this.Numero, this.VueltasRestantes, this.CantidadCombustible);
            datos.AppendFormat("{0,15}", this.CaballosDeFuerza);

            return datos.ToString();

        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);

        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool sonIguales = false;

            if (a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                sonIguales = true;

            }

            return sonIguales;

        }


    }
}
