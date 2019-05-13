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
    public partial class FrmLlamador : Form
    {
        public Centralita centralitaAux;

        public FrmLlamador(Centralita nuevaCentralita)
        {
            InitializeComponent();
            centralitaAux = nuevaCentralita;
        }

        public Centralita Central
        {
            get
            {
                return centralitaAux;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }
    }
}
