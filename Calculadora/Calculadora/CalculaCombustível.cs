using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class CalculaCombustivel
    {
        //Propriedades da classe
        private double ValorCombustivel { get; set; }

        private double ConsumoMedio { get; set; }

        public double Distancia { get; set; }

        public bool IdaVolta { get; set; }

        //Construtores

        public CalculaCombustivel(double valorCombustivel, double consumoMedio, double distancia, bool idaVolta)
        {
            ValorCombustivel = valorCombustivel;
            ConsumoMedio = consumoMedio;
            Distancia = distancia;
            IdaVolta = idaVolta;
        }

        public string[] Calcular()
        {
            double combustívelConsumido = Distancia / ConsumoMedio;
            double valorGasto = combustívelConsumido * ValorCombustivel;
            if (IdaVolta)
            {
                valorGasto *= 2;
                combustívelConsumido *=2;
            }

            string[] resultado = new string[2];
            resultado[0] = combustívelConsumido.ToString();
            resultado[1] = valorGasto.ToString();
            return resultado;
        }



    }
}
