using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;


        public Periferico(string marca, string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }

        public abstract string ExponerDatos();

        public static explicit operator string(Periferico p)
        {

            StringBuilder datos = new StringBuilder();
            
            datos.AppendLine(string.Format("{0} {1} <Puerto: {2}>",p.marca, p.modelo, p.conector));

            return datos.ToString();

        }

        public static bool operator !=(Periferico p1, Periferico p2)
        {

            return !(p1 == p2);

        }

        public static bool operator ==(Periferico p1, Periferico p2)
        {
            bool sonIguales = false;

            if(p1.marca == p2.marca && p1.modelo == p2.modelo)
            {
                sonIguales = true;
            }

            return sonIguales;

        }


    }
}
