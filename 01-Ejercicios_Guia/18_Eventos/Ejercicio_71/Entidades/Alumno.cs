using System;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private int dni;
        private string fotoAlumno;

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fotoAlumno = ruta;
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

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string RutaDeLaFoto
        {
            get
            {
                return this.fotoAlumno;
            }
            set
            {
                this.fotoAlumno = value;
            }
        }



        
    }
}
