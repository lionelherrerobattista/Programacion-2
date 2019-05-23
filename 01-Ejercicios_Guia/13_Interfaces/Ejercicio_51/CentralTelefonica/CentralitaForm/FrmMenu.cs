using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class FrmMenu : Form
    {
        Centralita nuevaCentralita;


        public FrmMenu()
        {
            InitializeComponent();
            nuevaCentralita = new Centralita("Call Center");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(nuevaCentralita);

            llamador.ShowDialog(this);

        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmFacturacionTotal = new FrmMostrar(nuevaCentralita, TipoLlamada.Todas);
            frmFacturacionTotal.ShowDialog(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmFacturacionTotal = new FrmMostrar(nuevaCentralita, TipoLlamada.Local);
            frmFacturacionTotal.ShowDialog(this);
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmFacturacionTotal = new FrmMostrar(nuevaCentralita, TipoLlamada.Provincial);
            frmFacturacionTotal.ShowDialog(this);
        }
    }
}
