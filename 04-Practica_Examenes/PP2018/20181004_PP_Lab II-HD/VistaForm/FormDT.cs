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

namespace VistaForm
{
  public partial class FormDT : Form
  {
    public FormDT()
    {
      InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void buttonCrear_Click(object sender, EventArgs e)
    {
      DirectorTecnico dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value,
        (int)numericUpDownDNI.Value, (int)numericUpDownExperiencia.Value);

      MessageBox.Show("Se ha creado el DT");
    }

    private void buttonValidar_Click(object sender, EventArgs e)
    {

    }
  }
}
