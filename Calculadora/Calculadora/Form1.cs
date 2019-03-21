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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculadora_Padrão novo = new Calculadora_Padrão();
            novo.Show();
            this.Visible = false;
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void BtnJur_Comp_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show();
            this.Visible = false;
        }
    }
}
