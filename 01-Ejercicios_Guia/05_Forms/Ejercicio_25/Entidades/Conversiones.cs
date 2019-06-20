using System;

namespace Entidades
{
    public class Conversiones
    {
        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario">número binario a convertir</param>
        /// <returns>número decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            int i;
            int j = 0;
            double numeroDecimal = 0;
            string resultado = "Valor inválido";
            bool esBinario = true;

            for (i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')//no es binario
                {
                    esBinario = false;
                    break;

                }
            }

            if (esBinario)
            {
                for (i = binario.Length - 1; i >= 0; i--)
                {

                    if (binario[i] == '1')
                    {
                        numeroDecimal += Math.Pow(2, j);
                    }

                    j++;

                }

                resultado = numeroDecimal.ToString();
            }

            return resultado;

        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">número decimal a convertir</param>
        /// <returns>número binario</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            string retorno = "";
            int i;

            numero = (int)Math.Abs(numero);

            if (numero > 1)
            {
                do
                {
                    if (numero % 2 == 0)
                    {
                        binario += "0";
                    }
                    else
                    {
                        binario += "1";
                    }

                    numero = (int)numero / 2;

                } while (numero > 1);

                if (numero == 0)
                {
                    binario += "0";
                }
                else
                {
                    binario += "1";
                }


                for (i = binario.Length - 1; i >= 0; i--)
                {
                    retorno += binario[i];
                }

            }
            else if (numero == 0 || numero == 1)//si es 0 o 1
            {
                retorno = numero.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">número decimal a convertir</param>
        /// <returns>número binario</returns>
        public static string DecimalBinario(string numero)
        {
            double numeroDouble;
            string numeroString;

            if (Double.TryParse(numero, out numeroDouble))
            {
                numeroString = DecimalBinario(numeroDouble);
            }
            else
            {
                numeroString = "Valor inválido";
            }

            return numeroString;

        }

    }
}
