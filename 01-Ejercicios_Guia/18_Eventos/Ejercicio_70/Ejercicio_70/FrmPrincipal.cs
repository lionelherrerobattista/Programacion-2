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

            //Asocio los manejadores a los eventos
            this.frmTestDelegados.ActualizarNombre += this.frmMostrar.ActualizarNombre;
            this.frmTestDelegados.ActualizarFoto += this.frmMostrar.ActualizarFoto;
        }
    }
}
