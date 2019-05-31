using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(Math.Abs(vertice3.GetX() - vertice1.GetX()), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), Math.Abs(vertice3.GetY() - vertice1.GetY()));
        }

        public float Area()
        {
            float areaFinal;

            if(this.area == 0)
            {
                areaFinal = (Math.Abs(vertice3.GetX() - vertice1.GetX())) * Math.Abs(vertice3.GetY() - vertice1.GetY());
                this.area = areaFinal;
            }

            return this.area;
        }

        public float Perimetro()
        {
            float perimetroFinal;

            if(this.perimetro == 0)
            {
                perimetroFinal = ((Math.Abs(vertice3.GetX() - vertice1.GetX())) + Math.Abs(vertice3.GetY() - vertice1.GetY())) * 2;
                this.perimetro = perimetroFinal;
            }

            return this.perimetro;
            
        }

        public static string MostrarRectangulo(Rectangulo r)
        {
            string datos;

            r.Area();
            r.Perimetro();

            datos = String.Format("Datos del rectángulo:");
            datos = String.Format("{0}\nVertice 1: ({1},{2})", datos, r.vertice1.GetX(), r.vertice1.GetY());
            datos = String.Format("{0}\nVertice 2: ({1},{2})", datos, r.vertice2.GetX(), r.vertice2.GetY());
            datos = String.Format("{0}\nVertice 3: ({1},{2})", datos, r.vertice3.GetX(), r.vertice3.GetY());
            datos = String.Format("{0}\nVertice 4: ({1},{2})", datos, r.vertice4.GetX(), r.vertice4.GetY());
            datos = String.Format("{0}\n----------------------", datos);
            datos = String.Format("{0}\nÁrea: {1}", datos, r.area);
            datos = String.Format("{0}\nPerímetro: {1}", datos, r.perimetro);

            return datos;
        }
    }
}
