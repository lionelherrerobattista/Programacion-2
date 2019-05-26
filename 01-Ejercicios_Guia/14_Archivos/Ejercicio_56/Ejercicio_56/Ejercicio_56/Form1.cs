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
            
            StreamReader sr;

            //Muestra una ventana para seleccionar el archivo
            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog() == DialogResult.OK)
            {

                //busco el path
                this.PathArchivo = abrir.FileName;

                sr = new StreamReader(this.PathArchivo);

                rtbEditorDeTexto.Text = sr.ReadToEnd();

                sr.Close();
                
            }



        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string datos;

            SaveFileDialog save = new SaveFileDialog();


            if(save.ShowDialog() == DialogResult.OK)
            {
                this.PathArchivo = save.FileName;

                datos = rtbEditorDeTexto.Text;

                this.GuardarEnArchivo(this.PathArchivo, datos);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string datos;

            datos = rtbEditorDeTexto.Text;

            if (this.PathArchivo is null)
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);

            }
            else
            {
                this.GuardarEnArchivo(this.PathArchivo, datos);
            }
        }

        public bool GuardarEnArchivo(string path, string datos)
        {
            StreamWriter sw;

            bool estaGuardado = false;

            //Abre el archivo y guarda el texto
            sw = new StreamWriter(path);

            sw.WriteLine(datos);

            sw.Close();

            if(File.Exists(path))
            {
                estaGuardado = true;
            }

            return estaGuardado;
        }
    }
}
