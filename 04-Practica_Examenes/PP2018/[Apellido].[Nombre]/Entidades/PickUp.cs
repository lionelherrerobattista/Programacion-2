using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;


        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }
            


        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Patente: {0}", this.Patente);
            datos.AppendLine();
            datos.AppendFormat("Modelo: {0}", this.modelo);
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
