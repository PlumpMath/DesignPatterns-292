using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethodPattern
{
    public partial class Form1 : Form
    {
        private string foodName;
        private Food food;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            foodName = tbFoodName.Text;
            if (cbFoods.Text == "Soup")
                food = new Soup(foodName);
            else if (cbFoods.Text == "Sandwich")
                food = new Sandwich(foodName);
            else
                food = new Pasta(foodName);
            rtbSummary.Text += food.eat() + "\n";
        }
    }
}
