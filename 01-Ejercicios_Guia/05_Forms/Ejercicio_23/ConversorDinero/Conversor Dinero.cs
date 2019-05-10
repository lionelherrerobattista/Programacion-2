using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;



namespace ConversorDinero
{
    public partial class Conversor_Dinero : Form
    {
        public Conversor_Dinero()
        {
            InitializeComponent();
        }

        private void lblEuro_Click(object sender, EventArgs e)
        {

        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtEuroAEuro_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            double cantidad;

            Double.TryParse(txtEuro.Text, out cantidad);

            //Declaro los objetos
            Euro e1 = new Euro(cantidad);
            Pesos p1 = new Pesos(0);
            Dolar d1 = new Dolar(0);

            //Convierto
            p1 = (Pesos)e1;
            d1 = (Dolar)e1;

            //Muestro en los textbox
            txtEuroAEuro.Text = e1.GetCantidad().ToString();
            txtEuroAPesos.Text = p1.GetCantidad().ToString("#.##");
            txtEuroADolar.Text = d1.GetCantidad().ToString("#.##");
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad;

            Double.TryParse(txtDolar.Text, out cantidad);
            
            //Declaro los objetos
            Euro e1 = new Euro(0);
            Pesos p1 = new Pesos(0);
            Dolar d1 = new Dolar(cantidad);

            //Convierto
            e1 = (Euro)d1;
            p1 = (Pesos)d1;

            //Muestro en los textbox
            txtDolarAEuro.Text = e1.GetCantidad().ToString("0.##");
            txtDolarADolar.Text = d1.GetCantidad().ToString();
            txtDolarAPesos.Text = p1.GetCantidad().ToString("#.##");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double cantidad;

            Double.TryParse(txtPesos.Text, out cantidad);

            //Declaro los objetos
            Euro e1 = new Euro(0);
            Pesos p1 = new Pesos(cantidad);
            Dolar d1 = new Dolar(0);

            //Convierto
            e1 = (Euro)p1;
            d1 = (Dolar)p1;

            //Muestro en los textbox
            txtPesosAEuro.Text = e1.GetCantidad().ToString("0.##");
            txtPesosADolar.Text = d1.GetCantidad().ToString("0.##");
            txtPesosAPesos.Text = p1.GetCantidad().ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
