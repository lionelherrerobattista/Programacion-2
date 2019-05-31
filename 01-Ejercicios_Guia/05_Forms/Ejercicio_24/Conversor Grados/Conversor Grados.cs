using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grados;

namespace Conversor_Grados
{
    public partial class Conversor_Grados : Form
    {
        public Conversor_Grados()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            Fahrenheit f;
            double grados;

            txtFahrenheitAFahrenheit.Text = txtFahrenheit.Text;

            //Paso el texto a double
            if (Double.TryParse(txtFahrenheit.Text, out grados))
            {
                //Creo un objeto
                f = new Fahrenheit(grados);

                //Hago las operaciones y asignaciones
                txtFahrenheitACelsius.Text = ((Celsius)f).GetGrados().ToString("#.##");
                txtFahrenheitAKelvin.Text = ((Kelvin)f).GetGrados().ToString("#.##");
            }

            
            
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            Kelvin k;
            double grados;

            txtKelvinAKelvin.Text = txtKelvin.Text;

            //Paso el texto a double
            if (Double.TryParse(txtKelvin.Text, out grados))
            {
                //Creo un objeto
                k = new Kelvin(grados);

                //Hago las operaciones y asignaciones
                txtKelvinAFahrenheit.Text = ((Fahrenheit)k).GetGrados().ToString("#.##");
                txtKelvinACelsius.Text = ((Celsius)k).GetGrados().ToString("#.##");
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            Celsius c;
            double grados;

            txtCelsiusACelsius.Text = txtCelsius.Text;

            //Paso el texto a double
            if (Double.TryParse(txtCelsius.Text, out grados))
            {
                //Creo un objeto
                c = new Celsius(grados);

                //Hago las operaciones y asignaciones
                txtCelsiusAFahrenheit.Text = ((Fahrenheit)c).GetGrados().ToString("#.##");
                txtCelsiusAKelvin.Text = ((Kelvin)c).GetGrados().ToString("#.##");
            }
        }
    }
}
