using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
            

        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;

        }

        private float CalcularCosto()
        {
            float valor;

            valor = this.Duracion * this.costo;

            return valor;

        }

        protected override string  Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0}", base.Mostrar());
            datos.AppendFormat(" {0,-15}", this.CostoLlamada);

            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            bool esLocal = false;

            if(obj is Local)
            {
                esLocal = true;
            }

            return esLocal;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
