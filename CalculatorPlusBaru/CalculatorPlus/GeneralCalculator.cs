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
    public partial class GeneralCalculator : Form
    {
        public GeneralCalculator()
        {
            InitializeComponent();
        }

        double total = 0;
        operation operat = operation.None;
        
        private void buttonC_Click_1(object sender, EventArgs e)
        {
            listHasil.Clear();
            total = 0;
            operat = operation.None;
        }

        private double Hitung()
        {
            double hasil = double.Parse(listHasil.Text);

            if (operat == operation.Addition)
            {
                hasil = total + double.Parse(listHasil.Text);
            }
            else if (operat == operation.Substraction)
            {
                hasil = total - double.Parse(listHasil.Text);
            }
            else if (operat == operation.Multiplication)
            {
                hasil = total * double.Parse(listHasil.Text);
            }
            else if (operat == operation.Division)
            {
                hasil = total / double.Parse(listHasil.Text);
            }
            else if (operat == operation.Percentage)
            {
                hasil = (double.Parse(listHasil.Text) * 10) / 100;
            }
            listHasil.Clear();
            return hasil;
        }

        private void buttonDivide_Click_1(object sender, EventArgs e)
        {
            total = Hitung();
            operat = operation.Division;
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            total = Hitung();
            operat = operation.Multiplication;
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            total = Hitung();
            operat = operation.Substraction;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            total = Hitung();
            operat = operation.Addition;
        }

        private void buttonsama_Click(object sender, EventArgs e)
        {
            if (operat != operation.None)
            {
                listHasil.Text = Hitung().ToString();
                total = 0;
                operat = operation.None;
            }
        }

        private void buttontitik_Click(object sender, EventArgs e)
        {
            listHasil.Text += buttontitik.Text;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            total = Hitung();
            operat = operation.Percentage;
        }

        private void buttonKurung_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string s = listHasil.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            listHasil.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listHasil.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listHasil.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listHasil.Text += button9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listHasil.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listHasil.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listHasil.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listHasil.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listHasil.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listHasil.Text += button3.Text;
        }

        private void buttonnol_Click(object sender, EventArgs e)
        {
            listHasil.Text += buttonnol.Text;
        }

        private void buttonnol2_Click(object sender, EventArgs e)
        {
            listHasil.Text += buttonnol2.Text;
        }
    }
}
