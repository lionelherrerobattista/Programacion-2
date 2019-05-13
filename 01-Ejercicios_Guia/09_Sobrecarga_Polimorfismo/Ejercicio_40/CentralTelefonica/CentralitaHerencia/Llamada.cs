using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return duracion;

            }
        }

        public string NroDestino
        {
            get
            {

                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;

        }

        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();


            datos.AppendFormat("   {0, -10} {1, -10} {2, -10}", this.Duracion, this.NroDestino,
                this.NroOrigen);

            return datos.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;

            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }

            return retorno;

        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool sonIguales = false;

            if(l1.Equals(l2))
            {
                if(l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                {
                    sonIguales = true;
                }
                
            }

            return sonIguales;
        }
            
    }
}
