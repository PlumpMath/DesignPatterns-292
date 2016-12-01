using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public partial class Form1 : Form
    {
        Food food;
        public Form1()
        {
            InitializeComponent();
        }

        private void toastBtn_Click(object sender, EventArgs e)
        {
            food = new ConcreteFood(tbFood.Text);
            food.warm(new Toaster());
        }

        private void microwaveBtn_Click(object sender, EventArgs e)
        {
            food = new ConcreteFood(tbFood.Text);
            food.warm(new Microwave());
        }
    }
}
