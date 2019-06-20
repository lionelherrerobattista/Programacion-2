using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class FrmContadorPalabras : Form
    {
        private Dictionary<string, int> contadorPalabras;

        public FrmContadorPalabras()
        {
            InitializeComponent();
            this.contadorPalabras = new Dictionary<string, int>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto;
            string topTres = String.Empty;
            int contadorTopTres = 0;

            texto = this.rtbTexto.Text;
            
            //Separo las palabras
            string[] palabras = texto.Split(new char[] {'\n', ' ', ',', '.', ';'}, StringSplitOptions.RemoveEmptyEntries);

            //Tomo cada palabra del texto
            foreach(string palabra in palabras)
            {
                //Si está +1 al value
                if(this.contadorPalabras.ContainsKey(palabra))
                {
                    this.contadorPalabras[palabra]++;
                }
                else//si no está, agrego la palabra
                {
                    this.contadorPalabras.Add(palabra, 1);
                }
            }

            //Ordeno de manera descendente y guardo el Top 3 en un string
            foreach(KeyValuePair<string, int> palabra in this.contadorPalabras.OrderByDescending(key => key.Value))
            {
                if(topTres == String.Empty)
                {
                    topTres = String.Format("{0} --- {1}", palabra.Key, palabra.Value);

                }
                else
                {
                    topTres = String.Format("{0}\n{1} --- {2}", topTres, palabra.Key, palabra.Value);
                }
                contadorTopTres++;

                if(contadorTopTres == 3)
                {
                    break;
                }
            }

            //Muestro el top 3
            MessageBox.Show(topTres);

        }

        public int OrdenarDescendente(int a, int b)
        {
            int valor;

            if(a < b)
            {
                valor = 1;
            }
            else
            {
                valor = -1;
            }

            return valor;
        }
    }
}
