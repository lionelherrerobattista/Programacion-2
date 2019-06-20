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
    public partial class FrmTestDelegados : Form
    {

        public FrmTestDelegados()
        {
            InitializeComponent();

        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            
            this.ActualizarNombre.Invoke(this.txtDatos.Text);
        }

        public event DelegadoNombreLbl ActualizarNombre;
    }
}
