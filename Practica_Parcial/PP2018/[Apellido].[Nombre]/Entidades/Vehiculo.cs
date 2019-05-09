using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Count() == 6)
                {
                    this.patente = value;
                }
            }

        }

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0} \nIngreso:{1}", this.ToString(), this.ingreso);
           

            return datos.ToString();

        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool sonIguales = false;

            if(v1.patente == v2.patente && v1.GetType() == v2.GetType())
            {
                sonIguales = true;
            }

            return sonIguales;

        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return string.Format("Patente {0}", this.patente);
        }


    }
}
