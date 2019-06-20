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
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Entidades.Alumno alumno)
        {
            
            

            base.txtApellido.Text = alumno.Apellido;
            base.txtNombre.Text = alumno.Nombre;
            base.txtDni.Text = alumno.Dni.ToString();
            base.txtFoto.Text = alumno.RutaDeLaFoto;

            this.pictureAlumno.ImageLocation = alumno.RutaDeLaFoto;
        }

        private void FrmDatosAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
