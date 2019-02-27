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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtTemp_Orig.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double temp1, temp2;
            temp1 = double.Parse(txtTemp_Orig.Text);
            //temp2 = 0;
            
            switch (cboTempOrig.Text)
            {
            case "Kelvin":
                if (cboTempDest.Text == "Celsius")
                    {
                        temp2 = temp1 - 273.15;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Fahrenheit")
                    {
                        temp2 = (temp1 * 9 / 5) - 459.67;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
            break;
            case "Celsius)":
                if (cboTempDest.Text == "Kelvin")
                    {
                        temp2 = temp1 + 273.25;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Fahrenheit (ºF)")
                    {
                        temp2 = (temp1 * 9 / 5) + 32;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
            break;
            }
        }
    }
}
