using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;
        private FrmDatosAlumno frmDatosAlumno;
        private FrmAltaAlumno frmAltaAlumno;

       

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados = new FrmTestDelegados();

            this.frmTestDelegados.MdiParent = this;

            this.frmTestDelegados.Show();

            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();

            this.frmMostrar.MdiParent = this;

           
            this.frmMostrar.Show();

            this.frmTestDelegados.ActualizarNombre += this.frmMostrar.ActualizarNombre;
            this.frmTestDelegados.ActualizarFoto += this.frmMostrar.ActualizarFoto;
        }

        private void datosAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmDatosAlumno = new FrmDatosAlumno();

            this.frmDatosAlumno.Owner = this;

            this.frmDatosAlumno.MdiParent = this;

            this.frmDatosAlumno.Show();

            //suscribo al evento
            this.frmAltaAlumno.AlumnoNuevo += this.frmDatosAlumno.ActualizarAlumno;
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmAltaAlumno = new FrmAltaAlumno();

            this.frmAltaAlumno.Owner = this;

            this.frmAltaAlumno.MdiParent = this;

            this.frmAltaAlumno.Show();

            this.datosAlumnoToolStripMenuItem.Enabled = true;
        }
    }
}
