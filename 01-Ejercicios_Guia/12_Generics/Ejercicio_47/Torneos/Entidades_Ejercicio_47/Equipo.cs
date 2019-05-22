using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }

        public static bool operator ==(Equipo equipoUno, Equipo equipoDos)
        {
            bool sonIguales = false;

            if(equipoUno.nombre == equipoDos.nombre && equipoUno.fechaCreacion == equipoDos.fechaCreacion)
            {
                sonIguales = true;
            }

            return sonIguales;
        }


        public static bool operator !=(Equipo equipoUno, Equipo equipoDos)
        {
            return !(equipoUno == equipoDos);
        }

        public string Ficha()
        {
            string datos;

            datos = String.Format("{0} fundado el {1:d/M/yyyy}", this.nombre, this.fechaCreacion.Date);

            return datos;

        }
    }
}
