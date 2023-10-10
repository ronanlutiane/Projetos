using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalcularCombustivel : Form
    {
        public frmCalcularCombustivel()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double valorCombustivel = 0;
            double consumoMedio = 0;
            double distancia = 0;

            if (txtValorCombustivel.Text == "")
            {
                MessageBox.Show("Valor do combustível não pode ser vazio.");
                txtValorCombustivel.Focus();
            }
            else
            {
                valorCombustivel = Convert.ToDouble(txtValorCombustivel.Text);
            }

            if (txtConsumoMedio.Text == "")
            {
                MessageBox.Show("Consumo médio não pode ser vazio.");
                txtConsumoMedio.Focus();
            }
            else
            {
                consumoMedio = Convert.ToDouble(txtConsumoMedio.Text);
            }

            bool CalculaIdaVolta = chkIdaVolta.Checked;

            if (txtDistancia.Text == "")
            {
                MessageBox.Show("Distância a percorrer nao pode ser vazia.");
                txtDistancia.Focus();
            }
            else
            {
                distancia = Convert.ToDouble(txtDistancia.Text);
            }

            //string[] tipoCombustível = new string[4];
            //tipoCombustível[1] = "Gasolina";
            //tipoCombustível[2] = "Álcool";
            //tipoCombustível[3] = "Diesel";
            //tipoCombustível[4] = "GNV - Gás Natural Veicular";

            //var bindableNames = from name in tipoCombustível select new { Names = name };


            //lstTipoCombustível.DataSource = bindableNames.ToList();

            //lstTipoCombustível.DataSource = tipoCombustível;


            CalculaCombustivel calculo = new CalculaCombustivel(valorCombustivel,consumoMedio,distancia, CalculaIdaVolta);
            
            txtResultadoCombustivel.Text = calculo.Calcular()[0] + " litros de combustível.";
            txtResultadoValor.Text = "R$ " + calculo.Calcular()[1] + " reais.";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            //this.Visible = false;
            this.Close();
        }
    }
}
