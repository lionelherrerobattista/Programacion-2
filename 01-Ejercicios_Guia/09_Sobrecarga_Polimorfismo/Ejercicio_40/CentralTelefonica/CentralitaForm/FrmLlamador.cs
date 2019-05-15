using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {
        public Centralita centralitaAux;
        public Llamada nuevallamada;

        public FrmLlamador(Centralita nuevaCentralita)
        {
            InitializeComponent();
            centralitaAux = nuevaCentralita;
        }


        public Centralita Central
        {
            get
            {
                return centralitaAux;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion;
            float costo;
            string numeroDestino;
            // Lectura
            Provincial.Franja franjas;

            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            Random random = new Random();

            duracion = random.Next(1, 51);
            costo = random.Next(5, 57);
            costo /= 10;

            numeroDestino = txtNroDestino.Text;

            if(numeroDestino.Length > 0 && numeroDestino[0] == '#')
            {
                nuevallamada = new Provincial(txtNroOrigen.Text, franjas, duracion, txtNroDestino.Text);
            }
            else if(numeroDestino.Length > 0)
            {
                nuevallamada = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
            }

            //Agrego la llamada a la central
            this.centralitaAux = this.Central + nuevallamada;


        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }
            
            txtNroDestino.Text = String.Format("{0}","#");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text,"1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "9");
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "*");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }

            txtNroDestino.Text = String.Concat(txtNroDestino.Text, "0");
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));

            

            
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            string texto;

            texto = txtNroDestino.Text;

            if(texto.Length == 1 && texto[0] != '#')
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = true;
        }

        private void txtNroOrigen_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtNroOrigen.Text == "Nro Origen")
            {
                txtNroOrigen.Clear();
            }
        }
    }
}
