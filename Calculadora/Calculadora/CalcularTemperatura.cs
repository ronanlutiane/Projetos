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
    public partial class CalcularTemperatura : Form
    {
        public CalcularTemperatura()
        {
            InitializeComponent();
            txtTemp_Orig.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double temp1, temp2;
            temp1 = double.Parse(txtTemp_Orig.Text);
            temp2 = 0;
            
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
                else if (cboTempDest.Text == "Rankine")
                    {
                        temp2 = temp1 * 9 / 5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Réaumur")
                    {
                        temp2 = (temp1 - 273.15) * 4 / 5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Rømer")
                    {
                        temp2 = (temp1 - 273.15) * 21 / 40 + 7.5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Newton")
                    {
                        temp2 = (temp1 - 273.15) * 33 / 100;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Delisle")
                    {
                        temp2 = (373.15 - temp1) * 3 / 2;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else
                    {
                        txtTemp_Dest.Text = temp1.ToString();
                    }
            break;
            case "Celsius":
                if (cboTempDest.Text == "Kelvin")
                    {
                        temp2 = temp1 + 273.15;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Fahrenheit")
                    {
                        temp2 = (temp1 * 9 / 5) + 32;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Rankine")
                    {
                        temp2 = (temp1 + 273.15) * 9 / 5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Réaumur")
                    {
                        temp2 = temp1 * 4 / 5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Rømer")
                    {
                        temp2 = (temp1  * 21 / 40) + 7.5;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Newton")
                    {
                        temp2 = temp1 * 33 / 100;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else if (cboTempDest.Text == "Delisle")
                    {
                        temp2 = (100 - temp1) * 5/6;
                        txtTemp_Dest.Text = temp2.ToString();
                    }
                else
                    {
                        txtTemp_Dest.Text = temp1.ToString();
                    }
             break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Menu novo = new Menu();
            novo.Show();
            this.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            cboTempDest.Text = "";
            cboTempOrig.Text = "";
            txtTemp_Orig.Text = "";
            txtTemp_Dest.Text = "";
            txtTemp_Orig.Focus();
        }
    }
}
