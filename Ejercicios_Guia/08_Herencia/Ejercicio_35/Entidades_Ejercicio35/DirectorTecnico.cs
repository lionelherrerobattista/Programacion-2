using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre)
            : base (nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        
        public string MostrarDatos()
        {
            StringBuilder datosDirectorTecnico = new StringBuilder();

            datosDirectorTecnico.AppendFormat("{0, 15} {1, 15}", 
                this.Nombre, this.fechaNacimiento.Date.ToString("dd/MM/yyyy"));

            return datosDirectorTecnico.ToString();
        }
        
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);

        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool sonIguales = false;

            if(dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento)
            {
                sonIguales = true;
            }

            return sonIguales;
        }


    }
}
