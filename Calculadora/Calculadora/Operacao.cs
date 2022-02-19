using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacao
    {
        public string tipoOperacao;
        private double resultado = 0;
        public bool executouOperacao = false;
        public string ExecutarOperacao(double operando1, double operando2)
        {
            switch (tipoOperacao)
            {
                case "Adicao":
                    //resultado = Convert.ToDouble(operando1) + Convert.ToDouble(operando2);
                    resultado = operando1 + operando2;
                    //return resultado.ToString();
                    break;
                case "Subtracao":
                    //resultado = Convert.ToDouble(operando1) - Convert.ToDouble(operando2);
                    resultado = operando1 - operando2;
                    //return resultado.ToString();
                    break;
                case "Divisao":
                    //resultado = Convert.ToDouble(operando1) / Convert.ToDouble(operando2);
                    resultado = operando1 / operando2;
                    //return resultado.ToString();  
                    break;
                case "Multiplicacao":
                    //resultado = Convert.ToDouble(operando1) * Convert.ToDouble(operando2);
                    resultado = operando1 * operando2;
                    //return resultado.ToString();
                    break;
            }

            executouOperacao = true;
            return resultado.ToString();
        }
    }
}
