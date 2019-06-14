using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades_Ejercicio_67;

namespace Ejercicio_63
{
  public partial class Form1 : Form
  {

    public Thread t;
    public bool muestroHora = true;
    Temporalizador temporalizador;

    public Form1()
    {
      InitializeComponent();
    }


    public void AsignarHora()
    {

      this.lblHora.Text = DateTime.Now.ToString();



    }

    public void AsignarHoraTime()
    {

    
        if (this.lblHora.InvokeRequired)
        {
          this.lblHora.BeginInvoke((MethodInvoker)delegate ()
          {
            this.lblHora.Text = DateTime.Now.ToString();
          }
             );


        }
        else
        {
          this.lblHora.Text = DateTime.Now.ToString();
        }

      }

    public void AsignarHoraTime(Object myObject, EventArgs myEventArgs)
    {

      this.lblHora.Text = DateTime.Now.ToString();



    }

    public void AsignarHoraThread()
    {

      do
      {
        if (this.lblHora.InvokeRequired)
        {

          this.lblHora.BeginInvoke((MethodInvoker)delegate ()
              {
                this.lblHora.Text = DateTime.Now.ToString();
              }
             );


        }
        else
        {
          this.lblHora.Text = DateTime.Now.ToString();
        }

        Thread.Sleep(1000);

      } while (muestroHora);

    }



    private void Form1_Activated(object sender, EventArgs e)
    {
      this.temporalizador = new Temporalizador();

      this.temporalizador.Intervalo = 1000;

      this.temporalizador.Activo = true;

      this.temporalizador.EventoTiempo += this.AsignarHoraTime;

     

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.temporalizador.Activo = false;
    }
  }
}
