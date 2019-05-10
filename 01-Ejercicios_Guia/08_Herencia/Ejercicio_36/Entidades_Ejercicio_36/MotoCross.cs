using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_36
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {
            
        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0,5} {1,15} {2,15} ", this.CantidadCombustible, this.EnCompetencia, this.Escuderia);
            datos.AppendFormat("{3,15} {4,15} {5,15}", this.Numero, this.VueltasRestantes, this.CantidadCombustible);
            datos.AppendFormat("{6,15}", this.Cilindrada);

            return datos.ToString(); 
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2); 

        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            bool sonIguales = false;

            if(a1.Cilindrada == a2.Cilindrada)
            {
                sonIguales = true;
                
            }

            return sonIguales;

        }



    }
}
