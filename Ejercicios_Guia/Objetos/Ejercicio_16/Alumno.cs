using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if(nota1 >= 4 && nota2 >= 4)
            {
                Random r = new Random();

                notaFinal = r.Next(1, 11);
            }
            else
            {
                notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar()
        {
            string datosAlumno;

            datosAlumno = "Nombre: " + nombre + "\nApellido: " + apellido
                + "\nLegajo: " + legajo.ToString() + "\nNota 1: " + nota1.ToString()
                + "\nNota 2: " + nota2.ToString();

            if(notaFinal != -1)
            {
                datosAlumno += "\nNota Final: " + notaFinal.ToString();
            }
            else
            {
                datosAlumno += "\nNota Final: Alumno desaprobado.";
            }

            return datosAlumno;
        }

    }
}
