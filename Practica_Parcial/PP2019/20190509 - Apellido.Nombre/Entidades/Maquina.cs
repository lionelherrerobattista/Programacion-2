using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;

        public int CantidadMaximaPerifericos
        {
            get
            {
                return cantidadMaxPerifericos;
            }
            set
            {
                if(value > 4)
                {
                    cantidadMaxPerifericos = 4;
                }
                else if(value < 1)
                {
                    cantidadMaxPerifericos = 1;
                }
                else
                {
                    cantidadMaxPerifericos = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;

            }
            set
            {
                this.nombre = value;
            }
        }

        public string SystemInfo
        {
            get
            {
                StringBuilder datos = new StringBuilder();

                datos.AppendFormat("{0}:\n", this.Nombre);

                foreach(Periferico p in this.perifericos)
                {
                    datos.AppendLine(p.ExponerDatos());
                    datos.AppendLine();
                }

                return datos.ToString();
            }
        }

        private Maquina()
        {
            this.perifericos = new List<Periferico>();
            this.CantidadMaximaPerifericos = 3;

        }

        public Maquina(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);

        }

        public static bool operator ==(Maquina m, Periferico p)
        {
            bool estaPeriferico = false;

            foreach(Periferico auxPeriferico in m.perifericos)
            {
                if(p == auxPeriferico)
                {
                    estaPeriferico = true;
                    break;
                }
            }

            return estaPeriferico;

        }

        public static string operator -(Maquina m, Periferico p)
        {
            string mensaje = "No se puede desconectar el dispositivo.";

            foreach(Periferico auxiliarPeriferico in m.perifericos)
            {
                if (auxiliarPeriferico == p)
                {

                    m.perifericos.Remove(auxiliarPeriferico);
                    mensaje = "Periferico desconectado!";
                    break;
                }
            }

            return mensaje;
           
        }

        public static string operator +(Maquina m, Periferico p)
        {
            string mensaje;

            if(m != p && m.perifericos.Count < m.CantidadMaximaPerifericos )
            {
                m.perifericos.Add(p);
                

                mensaje = "Periferico conectado!";
            }
            else
            {
                mensaje = "No se puede conectar el dispositivo.";
            }

            return mensaje;
        }

    }
    
}
