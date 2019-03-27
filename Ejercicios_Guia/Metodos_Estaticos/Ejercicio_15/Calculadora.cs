using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos,
            char operacion)
        {
            double resultado = 0;

            switch(operacion)
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break;

                case '-':
                    resultado = numeroUno - numeroDos; 
                    break;

                case '*':
                    resultado = numeroUno * numeroDos;
                    break;

                case '/':
                    if(Calculadora.Validar(numeroDos) == true)
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("\nNo se puede dividir por cero.");
                    }
                    break;
            }

            return resultado;

        }//fin función

        private static bool Validar(double numeroDos)
        {
            bool esCero = true;

            if (numeroDos == 0)
            {
                esCero = false;
            }

            return esCero;
        }
    }
}
