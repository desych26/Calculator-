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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCurrency_Click(object sender, EventArgs e)
        {
            CurrencyCalculator frm = new CurrencyCalculator();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            GeneralCalculator frm = new GeneralCalculator();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonPhysics_Click(object sender, EventArgs e)
        {
            PhysicsCalculator frm = new PhysicsCalculator();
            frm.Owner = this;
            frm.Show();
        }
    }
}
