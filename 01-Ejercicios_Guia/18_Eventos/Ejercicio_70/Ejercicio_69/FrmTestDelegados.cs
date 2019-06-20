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

namespace Ejercicio_69
{
    public partial class FrmTestDelegados : Form
    {
        private string rutaFoto;

        public FrmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ActualizarNombre.Invoke(this.txtDatos.Text);
            this.ActualizarFoto.Invoke(this.rutaFoto);
            
        }

        public event DelegadoNombreLbl ActualizarNombre;
        public event DelegadoPictureBox ActualizarFoto;

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            //Pido al usuario que seleccione una foto
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.rutaFoto = openFileDialog1.FileName;
            }
        }
    }
}
