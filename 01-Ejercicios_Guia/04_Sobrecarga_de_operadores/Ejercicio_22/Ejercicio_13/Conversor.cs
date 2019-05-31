using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        //Convierte un número de decimal a binario
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            string retorno = "";
            int i;

            if (numero == 0)
            {
                retorno = numero.ToString();
            }
            else
            {
                do
                {
                    //Si es par
                    if (numero % 2 == 0)
                    {
                        binario += "0";
                    }
                    else
                    {
                        binario += "1";
                    }

                    //divido (tomo la parte entera)
                    numero = (int)numero / 2;

                } while (numero > 1);

                //Agrego el último número
                if (numero == 0)
                {
                    binario += "0";
                }
                else
                {
                    binario += "1";
                }

                //doy vuelta el número
                for (i = binario.Length - 1; i >= 0; i--)
                {
                    retorno += binario[i];
                }
            }

            return retorno;
        }

        public static double BinarioDecimal(string numero)
        {
            int i;
            int j = 0;
            double numeroDecimal = 0;

            for (i = numero.Length - 1; i >= 0; i--)
            {

                if (numero[i] == '1')//si es 1 en binario
                {
                    //lo multiplico por 2 ^ a la posición y los sumo
                    numeroDecimal += Math.Pow(2, j);
                }

                //Aumento la potencia
                j++;

            }//fin del for

            return numeroDecimal;

        }


    }
}
