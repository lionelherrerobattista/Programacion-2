using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            bool guardoArchivo = false;

            FileStream fs;
            BinaryFormatter ser;

            if (this.ValidarArchivo(ruta, true) == true)
            {


                fs = new FileStream(ruta, FileMode.Create);

                ser = new BinaryFormatter();

                ser.Serialize(fs, objeto);

                fs.Close();

                guardoArchivo = true;


            }

            return guardoArchivo;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            bool guardoArchivo = false;

            FileStream fs;
            BinaryFormatter ser;

            if (this.ValidarArchivo(ruta, false))
            {

                fs = new FileStream(ruta, FileMode.Create);

                ser = new BinaryFormatter();

                ser.Serialize(fs, objeto);

                fs.Close();

                guardoArchivo = true;

            }

            return guardoArchivo;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat auxiliar = null;

            if (this.ValidarArchivo(ruta, true))
            {
                
                FileStream fs;
                BinaryFormatter ser;

                fs = new FileStream(ruta, FileMode.Open);

                ser = new BinaryFormatter();

                auxiliar = (PuntoDat)ser.Deserialize(fs);

                fs.Close();
            }

            return auxiliar;
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool archivoExiste = false;

            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) == true)
                {
                    if (Path.GetExtension(ruta) == ".dat")//compruebo que la extensión coincida
                    {
                        archivoExiste = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }

                }
            }
            catch(ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
            
            return archivoExiste;
        }


    }
}
