using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_69
{
    //enlaces entre los froms que lanzan el evento y los que se suscriben
    public delegate void DelegadoNombreLbl(string nombre);
    public delegate void AlumnoNuevoDelegate(Entidades.Alumno alumno);
}
