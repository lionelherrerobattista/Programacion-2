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

namespace Ejercicio_69
{
    public partial class FrmAltaAlumno : Form
    {
        private string rutaFoto;
        private Alumno alumno;

        public event AlumnoNuevoDelegate AlumnoNuevo;

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            if(this.openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                this.rutaFoto = this.openFileDialogFoto.FileName;
                this.txtFoto.Text = this.rutaFoto;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int dni;
            string rutaFoto;

            if (Int32.TryParse(this.txtDni.Text, out dni))
            {
                nombre = this.txtNombre.Text;
                apellido = this.txtApellido.Text;
                rutaFoto = this.rutaFoto;

                this.alumno = new Alumno(nombre, apellido, dni, rutaFoto);

                //invoco al evento y le paso el alumno
                this.AlumnoNuevo.Invoke(this.alumno);
            }
            else
            {
                MessageBox.Show("El DNI debe ser numérico.");
            }
        }
    }
}
