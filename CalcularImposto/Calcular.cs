using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcularImposto;

namespace CalcularImposto
{
    public class Calcular
    {
        public static double Calculo(double renda)
        {
            double imposto = 0;

            if (renda <= 1903.99)
            {
                imposto = 0;
            }
            else if (renda > 1903.98 && renda < 2826.66)
            {
                imposto = ((renda * 7.50) / 100) - 142.80;
            }
            else if (renda > 2826.65 && renda < 3751.06)
            {
                imposto = ((renda * 15.00) / 100) - 304.80;
            }
            else if (renda > 3751.05 && renda < 4664.69)
            {
                imposto = ((renda * 22.50) / 100) - 636.13;
            }
            else if (renda > 4664.67)
            {
                imposto = ((renda * 27.50) / 100) - 869.36;
            }
            else
                imposto = 0;
            return imposto;
        }
    }
}