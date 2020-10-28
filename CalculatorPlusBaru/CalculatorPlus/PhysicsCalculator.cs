﻿using System;
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
    public partial class PhysicsCalculator : Form
    {
        public PhysicsCalculator()
        {
            InitializeComponent();
        }

        int sign_Indicator = 0;
        double variable1;
        double variable2;
        int additionPart = 0;
        int subbtractionPart = 0;
        int multiplicationPart = 0;
        int divisionPart = 0;
        int modBit = 0;
        Boolean fl = false;
        String s, x;

        private void calculate()
        {
            if (txtInput.Text != ".")
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (additionPart == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (subbtractionPart == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (multiplicationPart == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (divisionPart == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (modBit == 1)
                {

                    variable2 = Convert.ToInt32(txtInput.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }

                else
                {
                    variable1 = variable2;
                }
                txtInput.Text = Convert.ToString(variable1);

            }


        }

        private void reset_SignBits()
        {
            additionPart = 0;
            subbtractionPart = 0;
            multiplicationPart = 0;
            divisionPart = 0;
            modBit = 0;
            fl = false;
        }

        private void buttonTiga_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void buttonEnam_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void buttonDelapan_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void buttonPhi_Click(object sender, EventArgs e)
        {
            txtInput.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }

        private void button1x_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1 / Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Round(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            //if (sign_Indicator == 0)
            //{
            //    txtInput.Text = txtInput.Text + Convert.ToString(00);
            //}
            //else if (sign_Indicator == 1)
            //{
            //    txtInput.Text = Convert.ToString(00);
            //    sign_Indicator = 0;
            //}
            //fl = true;

            txtInput.Text += button00.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            fl = true;
        }

        private void buttonTitik_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtInput.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtInput.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    txtInput.Text = txtInput.Text + Convert.ToString(".");
                }
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Sin(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAkar_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(txtInput.Text);
            s = Math.Sqrt(l);
            txtInput.Text = Convert.ToString(s);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            sign_Indicator = 0;
            variable1 = 0;
            variable2 = 0;
            reset_SignBits();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                divisionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                multiplicationPart = 1;
                sign_Indicator = 1;
            }
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                subbtractionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                additionPart = 1;
                sign_Indicator = 1;
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            s = txtInput.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtInput.Text = x;
            x = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtInput.Text); i++)
                {
                    fact = fact * i;
                }
                txtInput.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            fl = true;
        }
    }
}
