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

    public class Llamada
    {


        

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

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

        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            
            datos.AppendFormat("   {0, -10} {1, -10} {2, -10}", this.Duracion, this.NroDestino,
                this.NroOrigen);

            return datos.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if(llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;

            }
            else if(llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }

            return retorno;

        }
    }
}
