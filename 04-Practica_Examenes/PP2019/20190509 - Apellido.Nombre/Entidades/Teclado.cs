using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public class Teclado : Periferico
    {
        private EDistribucion distribucion;

        public Teclado(string marca, string modelo, EConector conector)
            : base(marca, modelo, conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }

        public Teclado(string marca, string modelo, EConector conector, EDistribucion region)
            : this(marca, modelo, conector)
        {
            this.distribucion = region;

        }



        public override string ExponerDatos()
        {
            string datos;

            datos = string.Format("TECLADO {0}Distribucion {1}", (string)this, this.distribucion);
            

            return datos;
        }

        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);

        }

        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            bool sonIguales = false;

            if(t.distribucion == distribucion)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }

    }
}
