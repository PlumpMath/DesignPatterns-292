using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOperation.Items.Add(new Add());
            cbOperation.Items.Add(new Subtract());
            cbOperation.Items.Add(new Multiply());
            cbOperation.Items.Add(new Division());
            cbOperation.Items.Add(new Exponent());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Operate calculation = new Operate();
            calculation.setOperation((Operation)cbOperation.SelectedItem);
            double numOne = Double.Parse(tbNumOne.Text);
            double numTwo = Double.Parse(tbNumTwo.Text);
            double result = calculation.calculate(numOne, numTwo);
            labelResult.Text = result.ToString();
        }
    }
}
