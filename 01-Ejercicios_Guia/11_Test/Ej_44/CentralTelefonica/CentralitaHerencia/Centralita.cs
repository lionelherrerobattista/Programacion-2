using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita
    {
        
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                
                return this.CalcularGanancia(TipoLlamada.Local);

            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);

            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
                
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();

        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            int i;
            Local auxiliarLocal;
            Provincial auxiliarProvincial;
            float recaudado = 0;

            if(tipo == TipoLlamada.Local)
            {
                for(i = 0; i < this.Llamadas.Count; i++)
                {
                    if(this.Llamadas[i] is Local)
                    {
                        auxiliarLocal = (Local)this.Llamadas[i];

                        recaudado += auxiliarLocal.CostoLlamada;
                    }
                    
                }
            }
            else if(tipo == TipoLlamada.Provincial)
            {
                for (i = 0; i < this.Llamadas.Count; i++)
                {
                    if (this.Llamadas[i] is Provincial)
                    {
                        auxiliarProvincial = (Provincial)this.Llamadas[i];

                        recaudado += auxiliarProvincial.CostoLlamada;
                    }

                }
            }
            else if(tipo == TipoLlamada.Todas)
            {
                for (i = 0; i < this.Llamadas.Count; i++)
                {
                    if (this.Llamadas[i] is Local)
                    {
                        auxiliarLocal = (Local)this.Llamadas[i];

                        recaudado += auxiliarLocal.CostoLlamada;
                    }

                }

                for (i = 0; i < this.Llamadas.Count; i++)
                {
                    if (this.Llamadas[i] is Provincial)
                    {
                        auxiliarProvincial = (Provincial)this.Llamadas[i];

                        recaudado += auxiliarProvincial.CostoLlamada;
                    }

                }
            }

            return recaudado;
            

        }

        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Razón Social:{0}\nGanancia Total: {1}\nGanancia Local:{2}\nGanancia Provincial:{3}", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);
            datos.AppendLine();
            datos.AppendLine();
            datos.AppendLine("Detalle de llamadas:");
            datos.AppendLine();
            datos.AppendFormat("{0, 3} {1, 15} {2, 15} {3, 15}\n", "Duracion", "Destino", "Origen", "Costo");



            foreach (Llamada llamada in this.Llamadas)
            {
                datos.AppendFormat("{0}", llamada.ToString());
                datos.AppendLine();
            }

            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);

        
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool estaEnLista = false;

            foreach(Llamada auxLlamada in c.Llamadas)
            {
                if(auxLlamada == llamada)
                {
                    estaEnLista = true;
                    break;
                }
            }

            return estaEnLista;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            string mensaje;

            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {

              
              mensaje = "La llamada ya se encuentra en la lista";
              throw new CentralitaException(mensaje, "llamadaEnListaException", "Operator +");
            
  
            }






            return c;
        }
    }
}
