using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada)
            : base (patente)
        {

            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, 2)
        {
            Moto.valorHora = valorHora;

        }


        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(this.ToString());
            datos.AppendLine();
            datos.AppendFormat("Cilindrada: {0}\nRuedas:{1}", this.cilindrada, this.ruedas, valorHora);
            datos.AppendLine();

            return datos.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.ImprimirTicket());
            datos.AppendLine();
            datos.AppendFormat("Costo de estadía: {0}", ((DateTime.Now.Hour - base.ingreso.Hour) * valorHora));
            datos.AppendLine();

            return datos.ToString();
        }








    }
}
