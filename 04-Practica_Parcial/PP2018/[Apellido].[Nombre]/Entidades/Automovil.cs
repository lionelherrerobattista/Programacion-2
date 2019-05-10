using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base (patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this (patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Patente: {0}", this.Patente);
            datos.AppendLine();
            datos.AppendFormat("Color: {0}", this.color);
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
