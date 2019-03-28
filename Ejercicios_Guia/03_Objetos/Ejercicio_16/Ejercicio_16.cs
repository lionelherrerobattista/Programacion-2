using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            string auxiliarString;
            int auxiliarNumero;
            byte notaUno;
            byte notaDos;

            Console.Title = "Ejercicio Nro 16";

            //Creo los objetos Alumno
            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            //Ingreso datos alumnoUno (utilizo operador punto)
            Console.WriteLine("Alumno 1:");

            Console.Write("Nombre: ");
            alumnoUno.nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            alumnoUno.apellido = Console.ReadLine();

            Console.Write("Legajo: ");
            auxiliarString = Console.ReadLine();
            if(Int32.TryParse(auxiliarString, out auxiliarNumero))
            {
                alumnoUno.legajo = auxiliarNumero;
            }

            Console.Write("Nota 1: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaUno))
            {
                
            }

            Console.Write("Nota 2: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaDos))
            {

            }
            //Ingreso nota1 y nota2 a través del método estudiar
            alumnoUno.Estudiar(notaUno, notaDos);

            //Calculo la notaFinal invocando el método!!
            alumnoUno.CalcularFinal();

            //Muestro los parámetros del obj utilizando el método Mostrar()
            Console.WriteLine("\nDatos alumno:\n{0}", alumnoUno.Mostrar());

            //Repito para los demás alumnos:
            //Ingreso datos alumnoDos
            Console.WriteLine("\nAlumno 2:");

            Console.Write("Nombre: ");
            alumnoDos.nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            alumnoDos.apellido = Console.ReadLine();

            Console.Write("Legajo: ");
            auxiliarString = Console.ReadLine();
            if (Int32.TryParse(auxiliarString, out auxiliarNumero))
            {
                alumnoDos.legajo = auxiliarNumero;
            }

            Console.Write("Nota 1: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaUno))
            {

            }

            Console.Write("Nota 2: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaDos))
            {

            }

            alumnoDos.Estudiar(notaUno, notaDos);
            alumnoDos.CalcularFinal();
            Console.WriteLine("\nDatos alumno:\n{0}", alumnoDos.Mostrar());


            //Ingreso datos alumnoTres
            Console.WriteLine("\nAlumno 3:");

            Console.Write("Nombre: ");
            alumnoTres.nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            alumnoTres.apellido = Console.ReadLine();

            Console.Write("Legajo: ");
            auxiliarString = Console.ReadLine();
            if (Int32.TryParse(auxiliarString, out auxiliarNumero))
            {
                alumnoTres.legajo = auxiliarNumero;
            }

            Console.Write("Nota 1: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaUno))
            {

            }

            Console.Write("Nota 2: ");
            auxiliarString = Console.ReadLine();
            if (Byte.TryParse(auxiliarString, out notaDos))
            {

            }

            alumnoTres.Estudiar(notaUno, notaDos);
            alumnoTres.CalcularFinal();
            Console.WriteLine("\nDatos alumno:\n{0}", alumnoTres.Mostrar());


            Console.ReadKey();




        }
    }
}
