using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            Persona unaPersona;
            Persona personaLeida;

            unaPersona = new Persona("Juan", "Pérez");

            Console.WriteLine("Datos de la persona a guardar:");
            Console.WriteLine(unaPersona.ToString());

            path = Persona.Guardar(unaPersona);

            personaLeida = Persona.Leer(path);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Datos de la persona leída:");
            Console.WriteLine(personaLeida.ToString());

            Console.ReadKey();


        }
    }
}
