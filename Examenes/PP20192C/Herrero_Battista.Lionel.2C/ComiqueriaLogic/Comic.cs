using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic: Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipocomic)
            : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipocomic;

        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(base.ToString());
            datos.AppendFormat("Autor: {0}\n", this.autor);
            datos.AppendFormat("Tipo comic: {0}\n", this.tipoComic);
            

            return datos.ToString();

        }


        public enum TipoComic
        {
            Occidental,
            Oriental
        }

    }
}
