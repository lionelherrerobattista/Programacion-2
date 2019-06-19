using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_68
{
    public class Persona
    {
        private string apellido;
        private string nombre;

        public Persona()
        {
            this.apellido = "Pérez";
            this.nombre = "Juan";
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Mostrar()
        {
            string datos;

            datos = String.Format("{0}", this.nombre);
            datos = String.Format("{0} {1}", datos, this.apellido);

            return datos;
        }

        public event DelegadoString EventoString;
    }
}
