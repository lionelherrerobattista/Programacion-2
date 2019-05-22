using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }


        public string JugarPartido
        {
            get
            {
                int numeroRandom;
                Equipo equipoUno;
                Equipo equipoDos;

                Random random = new Random();

                numeroRandom = random.Next(0, this.equipos.Count);

                equipoUno = this.equipos[numeroRandom];

                do
                {
                    numeroRandom = random.Next(0, this.equipos.Count);

                    equipoDos = this.equipos[numeroRandom];

                } while (equipoUno == equipoDos);
                
                return CalcularPartido(this.equipos[numeroRandom], this.equipos[numeroRandom]);
            }
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre: {0}\n", this.nombre);
            datos.Append("Equipos:\n");

            foreach(Equipo equipo in this.equipos)
            {
                datos.AppendFormat("{0}\n", equipo.Ficha());
            }

            return datos.ToString();
        }

        private static string CalcularPartido(T equipo1, T equipo2)
        {
            int resultadoUno = 0;
            int resultadoDos = 0;
            string datos;

            Random random = new Random();

            if(equipo1 is EquipoFutbol && equipo2 is EquipoFutbol)
            {
                resultadoUno = random.Next(0, 6);
                resultadoDos = random.Next(0, 6);
            }

            if (equipo1 is EquipoBasquet && equipo2 is EquipoBasquet)
            {
                resultadoUno = random.Next(0, 121);
                resultadoDos = random.Next(0, 121);
            }


            datos = String.Format("{0} {1} - {2} {3}", equipo1.Nombre, resultadoUno, resultadoDos, equipo2.Nombre);

            return datos;

        }

        public static bool operator ==(Torneo<T> t, Equipo e1)
        {
            bool estaInscripto = false;

            foreach (Equipo auxEquipo in t.equipos)
            {
                if (auxEquipo == e1)
                {
                    estaInscripto = true;
                    break;
                }
            }

            return estaInscripto;
        }

        public static bool operator !=(Torneo<T> t, Equipo e1)
        {
            return !(t == e1);
        }

        public static bool operator +(Torneo<T> t, Equipo e1)
        {
            bool agregoTorneo = false;

            if (t != e1)
            {
                agregoTorneo = true;
                t.equipos.Add((T)e1);
            }

            return agregoTorneo;
        }

        

    }


}
