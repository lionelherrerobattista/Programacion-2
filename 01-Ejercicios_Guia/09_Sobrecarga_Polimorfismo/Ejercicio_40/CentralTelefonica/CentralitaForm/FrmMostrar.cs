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
    public partial class FrmMostrar : Form
    {
        private Centralita centralitaAux;
        private TipoLlamada tipoLlamada;

        TipoLlamada Tipo
        {
            set
            {
                this.tipoLlamada = value;
            }
        }


        public FrmMostrar(Centralita centralitaMain, TipoLlamada tipo)
        {
            InitializeComponent();
            centralitaAux = centralitaMain;
            this.Tipo = tipo;
        }

        private void FacturacionTotal_Load(object sender, EventArgs e)
        {      
            string datos;


            datos = String.Format("{0, 3} {1, 10} {2, 15} {3, 15}\n", "Duracion",
                "Destino", "Origen", "Costo");

            foreach (Llamada llamadaAux in centralitaAux.Llamadas)
            {
                switch(this.tipoLlamada)
                {
                    case TipoLlamada.Local:
                        if (llamadaAux is Local)
                        {
                            this.Text = "Facturación Local";
                            datos = String.Concat(datos, llamadaAux.ToString());
                            datos = String.Concat(datos, "\n");
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (llamadaAux is Provincial)
                        {
                            this.Text = "Facturación Provincial";
                            datos = String.Concat(datos, llamadaAux.ToString());
                            datos = String.Concat(datos, "\n");
                        }
                        break;
                    default:
                        this.Text = "Facturación Total";
                        datos = String.Concat(datos, llamadaAux.ToString());
                        datos = String.Concat(datos, "\n");
                        break;
                }

            }

            rtbFacturacionTotal.Text = datos;
        }
    }
}
