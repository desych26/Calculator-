using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPlus
{
    public partial class CurrencyCalculator : Form
    {
        public CurrencyCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double jawaban;
            double value = double.Parse(txtValue.Text.ToString());

            if (comboBoxFrom.SelectedItem == "Us Dollar")
            {
                if (comboBoxTo.SelectedItem == "Singapore Dollar")
                {
                    jawaban = value * 1.359;
                    Result.Items.Add(value + " USD = " + jawaban + " SGD ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Indonesia Rupiah")
                {
                    jawaban = value * 14.633;
                    Result.Items.Add(value + " USD = " + jawaban + " IDR ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Japanese Yen")
                {
                    jawaban = value * 104.632;
                    Result.Items.Add(value + " USD = " + jawaban + " JPY ");
                    Result.Items.Add("");
                }
                else
                {
                    Result.Items.Add(value + " USD = " + value + " USD ");
                    Result.Items.Add("");
                }

            }
            else if (comboBoxFrom.SelectedItem == "Japanese Yen")
            {
                if (comboBoxTo.SelectedItem == "Us Dollar")
                {
                    jawaban = value * 0.00955670;
                    Result.Items.Add(value + " JPY = " + jawaban + " USD ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Indonesia Rupiah")
                {
                    jawaban = value * 139.829;
                    Result.Items.Add(value + " JPY = " + jawaban + " IDR ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Singapore Dollar")
                {
                    jawaban = value * 0.0129836;
                    Result.Items.Add(value + " JPY = " + jawaban + " SGD ");
                    Result.Items.Add("");
                }
                else
                {
                    Result.Items.Add(value + " JPY = " + value + " JPY ");
                    Result.Items.Add("");
                }
            }
            else if (comboBoxFrom.SelectedItem == "Singapore Dollar")
            {
                if (comboBoxTo.SelectedItem == "Us Dollar")
                {
                    jawaban = value * 0.735955;
                    Result.Items.Add(value + " SGD = " + jawaban + " USD ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Indonesia Rupiah")
                {
                    jawaban = value * 10.767;
                    Result.Items.Add(value + " SGD = " + jawaban + " IDR ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Japanese Yen")
                {
                    jawaban = value * 77.0160;
                    Result.Items.Add(value + " SGD = " + jawaban + " JPY ");
                    Result.Items.Add("");
                }
                else
                {
                    Result.Items.Add(value + " SGD = " + value + " SGD ");
                    Result.Items.Add("");

                }
            }
            else
            {
                if (comboBoxTo.SelectedItem == "Us Dollar")
                {
                    jawaban = value * 0.0000683361;
                    Result.Items.Add(value + " IDR = " + jawaban + " USD ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Singapore Dollar")
                {
                    jawaban = value * 0.0000928434;
                    Result.Items.Add(value + " IDR = " + jawaban + " SGD ");
                    Result.Items.Add("");
                }
                else if (comboBoxTo.SelectedItem == "Japanese Yen")
                {
                    jawaban = value * 0.00715042;
                    Result.Items.Add(value + " IDR = " + jawaban + " JPY ");
                    Result.Items.Add("");
                }
                else
                {
                    Result.Items.Add(value + " IDR = " + value + " IDR ");
                    Result.Items.Add("");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            txtValue.Clear();
        }
    }
}
