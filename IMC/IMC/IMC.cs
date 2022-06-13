using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    public static class CalculoIMC
    {
        public static double ContaIMC(double peso, double altura)
        {
            return (Math.Round(peso / Math.Pow(altura, 2), 2));
        }

        public static string Classificacao(double imc)
        {
            if (imc < 18.5)
            {
                return ("Baixo peso");
            }
            else if (imc < 24.99)
            {
                return ("Peso normal");
            }
            else if (imc < 29.99)
            {
                return ("Sobrepeso");
            }
            else
            {
                return ("Obesidade");
            }
        }
    }
}