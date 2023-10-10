using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNum1.Focus();

            //o comando focus faz com que ao iniciar o cursor seja posicionado diretamente
            //dentro do textbox, sem que o usuario precise clicar.
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            try
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
                //num1 = Convert.ToInt32(txtNum1.Text);
                //num2 = Convert.ToInt32(txtNum2.Text);
                resultado = num1 + num2;
                //txtResultado.Text = Convert.ToString(resultado);
                txtResultado.Text = resultado.ToString();

                //Declaração de variaveis, atribuição de valores capturados e convertidos do textbox
                //O codigo comentado apresenta outra forma de fazer a conversao dos valores inseridos
                //o codigo comentado foi escrito por mim enquanto o outro foi a sugestao do curso
                //ver qual opção se encaixa melhor
            }
            catch(Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos", "Catch");
            }
            finally
            {
                MessageBox.Show("Aperte Ok para Sair");
                Close();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
            txtNum1.Focus();

            //codigo para limpar os dados inseridos e recolocar o cursor para nova digitação
        }
    }
}
