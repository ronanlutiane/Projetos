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
        double operando1, operando2;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //Menu novo = new Menu();
            //novo.Show();
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            tipoOperacao = "Adicao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
        }

        private void BtnSubtração_Click(object sender, EventArgs e)
        {
            tipoOperacao = "Subtracao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
        }

        private void BtnMultiplicação_Click(object sender, EventArgs e)
        {
            tipoOperacao = "Multiplicacao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            tipoOperacao = "Divisao";
            operando1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            operando1 = 0;
            operando2 = 0;
        }   

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                operando2 = double.Parse(txtVisor.Text);
            }
            else
            {
                operando2 = operando1;
            }
            Operacao operacao = new Operacao();
            operacao.tipoOperacao = tipoOperacao;
            txtVisor.Text = operacao.ExecutarOperacao(operando1, operando2);
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

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                txtVisor.Text = "0,";
                    }
            else
            {
                txtVisor.Text = txtVisor.Text + ",";
            }

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
    }
}
