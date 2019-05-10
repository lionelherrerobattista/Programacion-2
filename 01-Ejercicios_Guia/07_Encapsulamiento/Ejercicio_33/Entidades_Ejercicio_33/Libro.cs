using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                string pagina = "";

                if ( i >= 0 && i < this.paginas.Count)
                {
                    pagina = this.paginas[i];
                }

                return pagina;
            }
            set
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }

            }


        }

        public Libro()
        {
            this.paginas = new List<string>();
        }
            
          




    }
}
