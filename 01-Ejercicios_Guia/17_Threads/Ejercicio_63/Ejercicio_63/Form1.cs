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

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {

        public Thread t;
        public bool muestroHora = true;

        public Form1()
        {
            InitializeComponent();
        }


        public void AsignarHora()
        {

            this.lblHora.Text = DateTime.Now.ToString();



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
            
            t = new Thread(this.AsignarHoraThread);

            t.Start();

            
             /* Objeto Timer *
            Timer timer = new Timer();

            timer.Tick += new EventHandler(this.AsignarHoraTime); 

            timer.Interval = 1000;

            timer.Start();
            */
            

            
             /* Estructura de control 
            do
            {
                this.AsignarHora();

                System.Threading.Thread.Sleep(1000);

                

            } while (true);
            */
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(t.IsAlive)
            {
                muestroHora = false;
            }
        }
    }
}
