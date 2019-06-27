using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {

        private List<Grupo> grupos;
        private string nombre;
        public const int MAX_EQUIPOS_GRUPO = 4;


        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;

        }

        public List<Grupo> Grupos
        {
            get
            {
                return this.grupos;
            }

            set
            {
                this.grupos = value;
            }
        }

        public bool Guardar()
        {
            string path;
            bool archivoGuardado = true;

            XmlTextWriter writer;
            XmlSerializer ser;

            foreach (Grupo g in this.grupos)
            {
                path = String.Format("{0}\\grupo-{1}.xml",
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop), g.LetraGrupo);

                try
                {
                    writer = new XmlTextWriter(path, Encoding.UTF8);

                    ser = new XmlSerializer(typeof(Grupo));

                    ser.Serialize(writer, g);

                    writer.Close();
                }
                catch
                {
                    archivoGuardado = false;
                }

            }

            return archivoGuardado;
        }

        public bool Leer()
        {
            string path;
            bool grupoA = false;
            bool grupoB = false;
            bool grupoC = false;
            bool grupoD = false;
            bool archivoLeido = true;

            Grupo auxGrupo;

            XmlTextReader reader;
            XmlSerializer ser;

            foreach (Grupo g in this.grupos)
            {
                switch (g.LetraGrupo)
                {
                    case Letras.A:
                        grupoA = true;
                        break;
                    case Letras.B:
                        grupoB = true;
                        break;
                    case Letras.C:
                        grupoC = true;
                        break;
                    case Letras.D:
                        grupoD = true;
                        break;
                }
            }

            if (grupoA == false)
            {


                path = String.Format("{0}\\grupo-A.xml",
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

                if (File.Exists(path))
                {
                    try
                    {
                        auxGrupo = new Grupo();

                        reader = new XmlTextReader(path);

                        ser = new XmlSerializer(typeof(Grupo));

                        auxGrupo = (Grupo)ser.Deserialize(reader);

                        reader.Close();

                        this.grupos.Add(auxGrupo);
                    }
                    catch
                    {
                        archivoLeido = false;

                    }



                }
            }

            if (grupoB == false)
            {


                path = String.Format("{0}\\grupo-B.xml",
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

                if (File.Exists(path))
                {
                    try
                    {
                        auxGrupo = new Grupo();

                        reader = new XmlTextReader(path);

                        ser = new XmlSerializer(typeof(Grupo));

                        auxGrupo = (Grupo)ser.Deserialize(reader);

                        reader.Close();

                        this.grupos.Add(auxGrupo);
                    }
                    catch
                    {
                        archivoLeido = false;
                    }
                }
            }

            if (grupoC == false)
            {


                path = String.Format("{0}\\grupo-C.xml",
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

                if (File.Exists(path))
                {
                    try
                    {
                        auxGrupo = new Grupo();

                        reader = new XmlTextReader(path);

                        ser = new XmlSerializer(typeof(Grupo));

                        auxGrupo = (Grupo)ser.Deserialize(reader);

                        reader.Close();

                        this.grupos.Add(auxGrupo);
                    }
                    catch
                    {
                        archivoLeido = false;
                    }

                }
            }

            if (grupoD == false)
            {


                path = String.Format("{0}\\grupo-D.xml",
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

                if (File.Exists(path))
                {
                    try
                    {
                        auxGrupo = new Grupo();

                        reader = new XmlTextReader(path);

                        ser = new XmlSerializer(typeof(Grupo));

                        auxGrupo = (Grupo)ser.Deserialize(reader);

                        reader.Close();

                        this.grupos.Add(auxGrupo);
                    }
                    catch
                    {
                        archivoLeido = false;
                    }

                }


            }

            return archivoLeido;
        }

        public void SimularGrupos()
        {
            foreach(Grupo g in this.grupos)
            {
                g.Simular();

                this.eventoResultados.Invoke(g);
            }
        }

        public delegate void DelegadoResultados(Grupo o);

        public event DelegadoResultados eventoResultados;



    }

    
}
