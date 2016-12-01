using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        Context drink;
        public Form1()
        {
            InitializeComponent();
            drink = new Context();
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            drink.nextState();
            lblLevel.Text = drink.getTemp();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drink.getMessage());
            drink.drankCup();
            lblLevel.Text = drink.getTemp();
        }
    }
}
