using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3

        }

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();

            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;

            

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
            

        }

        private float CalcularCosto()
        {
            float costo;
            
            if(this.franjaHoraria == Franja.Franja_1)
            {
                costo = this.Duracion * (float)0.99;

            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                costo = this.Duracion * (float)1.25;
            }
            else
            {
                costo = this.Duracion * (float)0.66;
            }

            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0}", base.Mostrar());
            datos.AppendFormat(" {0,-15}", this.CostoLlamada);

            return datos.ToString();

        }

        public override bool Equals(object obj)
        {
            bool esProvincial = false;

            if(obj is Provincial)
            {
                esProvincial = true;
            }

            return esProvincial;
             
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
