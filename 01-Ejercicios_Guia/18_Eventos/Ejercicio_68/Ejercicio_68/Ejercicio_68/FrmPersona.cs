using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Ejercicio_68;

namespace Ejercicio_68
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        private DelegadoString delegado;


        public FrmPersona()
        {
            InitializeComponent();
        }


        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.delegado += NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string mensaje;

            if(this.persona is null)
            {
                this.persona = new Persona();

                if(txtApellido.Text != "")
                {
                    this.persona.Apellido = txtApellido.Text;
                }
                
                if(txtNombre.Text != "")
                {
                    this.persona.Nombre = txtNombre.Text;
                }
                

                btnCrear.Text = "Actualizar";

                mensaje = String.Format("La persona {0} se ha creado", this.persona.Mostrar());

                this.delegado.Invoke(mensaje);

                
            }
            else
            {
                if(this.persona.Apellido != txtApellido.Text && this.persona.Nombre == txtNombre.Text)
                {
                    if (txtApellido.Text != "")
                    {
                        this.persona.Apellido = txtApellido.Text;

                        mensaje = String.Format("Se ha actualizado el apellido de {0}", this.persona.Mostrar());

                        this.delegado.Invoke(mensaje);
                    }
                        
                }
                else if(this.persona.Apellido == txtApellido.Text && this.persona.Nombre != txtNombre.Text)
                {
                    if (txtNombre.Text != "")
                    {
                        this.persona.Nombre = txtNombre.Text;

                        mensaje = String.Format("Se ha actualizado el nombre de {0}", this.persona.Mostrar());

                        this.delegado.Invoke(mensaje);
                    }

                }
                else if(this.persona.Apellido != txtApellido.Text && this.persona.Nombre != txtNombre.Text)
                {
                    if (txtApellido.Text != "" && txtNombre.Text != "")
                    {
                        this.persona.Apellido = txtApellido.Text;
                        this.persona.Nombre = txtNombre.Text;

                        mensaje = String.Format("Se ha actualizado el nombre y el apellido de {0}", this.persona.Mostrar());

                        this.delegado.Invoke(mensaje);
                    }
                       
                }
            }
        }
    }
}
