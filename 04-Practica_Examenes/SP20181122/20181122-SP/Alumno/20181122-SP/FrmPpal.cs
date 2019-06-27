using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;



namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;
 
        public FrmPpal()
        {
            InitializeComponent();
            
            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion += this.ProximaPatente;
            this.vistaPatente2.finExposicion += this.ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();

        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<List<Patente>> archivoXml = new Xml<List<Patente>>();

            List<Patente> auxPatentes = new List<Patente>();

            try
            {
                archivoXml.Leer("patentes.xml", out auxPatentes);

                foreach(Patente p in auxPatentes)
                {
                    this.cola.Enqueue(p);
                }

                this.IniciarSimulacion();
            }
            catch(Exception xmlException)
            {
                MessageBox.Show(xmlException.Message);
            }
            
            
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto archivosDeTexto = new Texto();

            try
            {

                archivosDeTexto.Leer("patentes.txt", out this.cola);
                this.IniciarSimulacion();

            }
            catch
            {
                MessageBox.Show("Error al leer archivo de texto");
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql archivoSQL = new Sql();

            try
            {

                archivoSQL.Leer("Patentes", out this.cola);

                this.IniciarSimulacion();

            }
            catch
            {
                MessageBox.Show("Error al leer Base de Datos");
            }
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in this.hilos)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }

        public void IniciarSimulacion()
        {
            this.FinalizarSimulacion();

            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);


        }

        public void ProximaPatente(Patentes.VistaPatente o)
        {
            if(this.cola.Count != 0)
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(o.MostrarPatente));

                t1.Start(this.cola.Dequeue());

                this.hilos.Add(t1);
            }

            
        }


    }
}
