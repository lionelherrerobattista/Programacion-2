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
    }
}
