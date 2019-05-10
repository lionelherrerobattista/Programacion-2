using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueriaActual;

        public VentasForm(Producto productoSeleccionado, Comiqueria comiqueria)
        {
            InitializeComponent();
            lblDescripcion.Text = productoSeleccionado.Descripcion;
            producto = productoSeleccionado;
            comiqueriaActual = comiqueria;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = String.Format("Precio Final: $ {0:0.00}",
                Venta.CalcularPrecioFinal(producto.Precio, (int)numericUpDownCantidad.Value));

        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {

            lblPrecioFinal.Text = String.Format("Precio Final: $ {0:0.00}",
                Venta.CalcularPrecioFinal(producto.Precio, (int)numericUpDownCantidad.Value));
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
          
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            

            if ((int)numericUpDownCantidad.Value > producto.Stock)
            {
                MessageBox.Show("Superó el stock disponible", "Máximo superado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                comiqueriaActual.Vender(producto, (int)numericUpDownCantidad.Value);

                this.DialogResult = DialogResult.OK;
                

                this.Close();
                
            }
        }
    }
}
