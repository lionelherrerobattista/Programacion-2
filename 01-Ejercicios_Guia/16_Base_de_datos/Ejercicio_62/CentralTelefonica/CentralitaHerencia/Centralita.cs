using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private string rutaDeArchivo;


        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();

        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

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

        public String RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }

            set
            {
                rutaDeArchivo = value;
            }

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

                if (c.Guardar() == false)
                {
                    throw new FallaLogException();
                }
                
                
            }
            else
            {

              
              mensaje = "La llamada ya se encuentra en la lista";
              throw new CentralitaException(mensaje, "llamadaEnListaException", "Operator +");
            
  
            }

            return c;
        }

        public bool Guardar()
        {
            string path;
            string datosLlamada;
            bool guardoDatos = false;

            DateTime dt;
            StreamWriter sw;

            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = String.Format("{0}\\{1}.txt", path, "logLlamadas");

            rutaDeArchivo = path;

            sw = new StreamWriter(RutaDeArchivo, true);

            dt = DateTime.Now;

            datosLlamada = dt.ToString("dd 'd'e MMMM 'd'e yyyy hh:mm", new CultureInfo("es-ES"));

            datosLlamada = String.Format("{0}hs - Se realizó una llamada", datosLlamada);

            sw.WriteLine(datosLlamada);

            sw.Close();

            if(File.Exists(RutaDeArchivo))
            {
                guardoDatos = true;
            }

            return guardoDatos;
        }

        public string Leer()
        {
            string datos = "";
            StreamReader sr;

            if (File.Exists(this.RutaDeArchivo))
            {
                sr = new StreamReader(this.RutaDeArchivo);

                datos = sr.ReadToEnd();

                sr.Close();
            }

            return datos;
        }
    }
}
