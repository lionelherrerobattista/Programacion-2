using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {

        private string pathArchivo;

        public string PathArchivo
        {
            get
            {
                return this.pathArchivo;
            }
            set
            {
                this.pathArchivo = value;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void rtbEditorDeTexto_TextChanged(object sender, EventArgs e)
        {
            string datos;

            //Actualiza la cantidad de caracteres que se muestran en el tooltip
            datos = String.Format("{0} caracteres", rtbEditorDeTexto.Text.Count());

            tslCantidadCaracteres.Text = datos;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //StreamReader sr;

            PuntoTxt archivoTxt = new PuntoTxt();
            PuntoDat archivoDat = new PuntoDat();
            

            //Muestra una ventana para seleccionar el archivo
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                this.PathArchivo = abrir.FileName;

                switch (abrir.FilterIndex)
                {
                    case 1://texto
                        rtbEditorDeTexto.Text = archivoTxt.Leer(this.PathArchivo);
                        break;

                    case 2://binario
                        //Guardo el .dat en una variable
                        archivoDat = archivoDat.Leer(this.PathArchivo);
                        //Leo el texto que está en la propiedad contenido
                        rtbEditorDeTexto.Text = archivoDat.Contenido;
                        break;
                }

                
            }



        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt archivoTxt;
            PuntoDat archivoDat;

            
            archivoTxt = new PuntoTxt();
            archivoDat = new PuntoDat();

            string datos;

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";

            if (save.ShowDialog() == DialogResult.OK)
            {
                this.PathArchivo = save.FileName;

                datos = rtbEditorDeTexto.Text;

                switch (save.FilterIndex)
                {
                    case 1://texto
                        archivoTxt.GuardarComo(this.PathArchivo, datos);
                        break;

                    case 2://binario
                        //Guardo el texto en la propiedad contenido
                        archivoDat.Contenido = datos;
                        //Le paso el objeto PuntoDat con el texto cargado
                        archivoDat.GuardarComo(this.PathArchivo, archivoDat);
                        break;
                  
                }

                
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string datos;

            PuntoDat archivoDat;
            PuntoTxt archivoTxt;

            archivoDat = new PuntoDat();
            archivoTxt = new PuntoTxt();

            datos = rtbEditorDeTexto.Text;

            if (this.PathArchivo is null)
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);

            }
            else
            {
                switch(Path.GetExtension(this.PathArchivo))
                {
                    case ".txt":
                        archivoTxt.GuardarComo(this.PathArchivo, datos);
                        break;
                    case ".dat":
                        //Guardo el texto en la propiedad contenido
                        archivoDat.Contenido = datos;
                        //Le paso el objeto PuntoDat con el texto cargado
                        archivoDat.GuardarComo(this.PathArchivo, archivoDat);
                        break;
                }
            }
        }

       
    }
}
