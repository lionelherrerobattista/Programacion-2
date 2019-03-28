using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        //Parámetros de alumno:
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
                Random r = new Random();//genero un objeto random

                notaFinal = r.Next(1, 11);//máx. no incluído
            }
            else
            {
                notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno, byte notaDos)//para guardar las notas
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar()
        {
            string datosAlumno;//string que voy a devolver

            //Ingreso los datos y concateno
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
