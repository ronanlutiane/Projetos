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
            int num1, num2, resultado;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnAdiçao_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMultiplicação_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnSubtração_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
