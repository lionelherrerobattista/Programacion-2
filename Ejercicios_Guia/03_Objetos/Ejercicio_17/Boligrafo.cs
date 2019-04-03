using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(int gasto, out string dibujo)
        {
            int i;
            short auxiliarTinta;
            bool pinto = false;

            dibujo = "";

            if(this.tinta > 0 && gasto > 0)
            {
                pinto = true;

                auxiliarTinta = (short)(0 - gasto);

                //resto
                this.SetTinta(auxiliarTinta);
             
                for(i = this.tinta; i > 0; i--)
                {
                    dibujo += "*";
                    gasto--;

                    if(gasto == 0)
                    {
                        break;
                    }
                }
            }

            return pinto;
        }

        public void Recargar()
        {
            short recarga;
            
            recarga = (short)(cantidadTintaMaxima - this.tinta);//Castear toda la cuenta
            
            //reutilizo código
            this.SetTinta(recarga);
        }

        private void SetTinta(short tinta)
        {
            short auxiliarTinta;

            auxiliarTinta = this.tinta;

            if(tinta > 0)//cargo tinta
            {
        
                auxiliarTinta += tinta;
            }
            else if(tinta < 0)//gasto tinta
            {
                auxiliarTinta -= tinta;
            }

            //compruebo si no me paso
            if(auxiliarTinta >= 0 && auxiliarTinta <cantidadTintaMaxima)
            {
                this.tinta = auxiliarTinta;
            }
            else
            {
                if(auxiliarTinta <= 0)
                {
                    this.tinta = 0;
                }
                else
                {
                    this.tinta = cantidadTintaMaxima;
                }
                
            }    

        }

    }
}
