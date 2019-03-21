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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Visible = false;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtJuros.Text = "";
            txtPrazo.Text = "";
            txtVfinal.Text = "";
            txtVini.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double vini, vfinal, taxa, prazo;
            vini = double.Parse(txtVini.Text);
            vfinal = double.Parse(txtVfinal.Text);
            taxa = double.Parse(txtJuros.Text);
            prazo = double.Parse(txtPrazo.Text);

            if (cboTempPrazo.Text == "Ao mês" && cboTempTaxa.Text == "Ao mês" || cboTempPrazo.Text == "Ao ano" && cboTempTaxa.Text == "Ao ano" || cboTempPrazo.Text == "Ao dia" && cboTempTaxa.Text == "Ao dia")
            {
                if (txtVfinal.Text == "")
                {
                    vfinal = vini * Math.Pow((1 + (taxa / 100)), prazo);
                    txtVfinal.Text = vfinal.ToString();
                }
                else if (txtVini.Text == "")
                {
                    vini = vfinal / Math.Pow((1 + (taxa / 100)), prazo);
                    txtVini.Text = vini.ToString();
                }
            }
            MessageBox.Show("Situaçao ainda não codificada");
        }
    }
}
