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
    public partial class Calculadora_Padrão : Form
    {
        public Calculadora_Padrão()
        {
            InitializeComponent();
        }

        String tipoOperacao = "";
        double operando1, operando2, resultado;

        private void Button5_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            //Operacao operacao = new Operacao();
            //operacao.tipoOperacao = "Divisao";

            tipoOperacao = "Divisao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";

        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {

            //Operacao operacao = new Operacao();
            //operacao.tipoOperacao = "Adicao";

            tipoOperacao = "Adicao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            operando1 = 0;
            operando2 = 0;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMultiplicação_Click(object sender, EventArgs e)
        {
            //Operacao operacao = new Operacao();
            //operacao.tipoOperacao = "Multiplicacao";

            tipoOperacao = "Multiplicacao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";

        }


        private void BtnSubtração_Click(object sender, EventArgs e)
        {
            //Operacao operacao = new Operacao();
            //operacao.tipoOperacao = "Subtracao";

            tipoOperacao = "Subtracao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            operando2 = double.Parse(txtVisor.Text);
            switch (tipoOperacao) {
                case "Adicao":
                    resultado = operando1 + operando2;
                    txtVisor.Text = resultado.ToString();
                    break;
                case "Subtracao":
                    resultado = operando1 - operando2;
                    txtVisor.Text = resultado.ToString();
                    break;
                case "Divisao":
                    resultado = operando1 / operando2;
                    txtVisor.Text = resultado.ToString();
                    break;
                case "Multiplicacao":
                    resultado = operando1 * operando2;
                    txtVisor.Text = resultado.ToString();
                    break;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void btnHum_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btnMudarSinal_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                double alterandoSinal;
                alterandoSinal = Convert.ToDouble(txtVisor.Text) * -1;
                txtVisor.Text = alterandoSinal.ToString(); 
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }
    }
}
