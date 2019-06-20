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

namespace Ejercicio_25
{
    public partial class FrmConversorNumerico : Form
    {
        public FrmConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            this.txtDecimalDestino.Text = Conversiones.BinarioDecimal(this.txtBinarioOrigen.Text);
        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            this.txtBinarioDestino.Text = Conversiones.DecimalBinario(this.txtDecimalOrigen.Text);
        }
    }
}
