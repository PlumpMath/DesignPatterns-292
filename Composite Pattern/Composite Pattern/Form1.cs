using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    public partial class Form1 : Form
    {
        Division bigTen = new Division("Big Ten");
        Division bigTenEast = new Division("Big Ten East");
        Division bigTenWest = new Division("Big Ten West");
        Division independents = new Division("Independents");
        public Form1()
        {
            bigTenEast.add(new Team("Michigan", "Wolverines", 6, 0));
            bigTenEast.add(new Team("Ohio State", "Buckeyes", 6, 0));
            bigTenEast.add(new Team("Penn State", "Nittany Lions", 4, 2));
            bigTenEast.add(new Team("Maryland", "Terrapins", 4, 2));
            bigTenEast.add(new Team("Indiana", "Hoosiers", 3, 3));
            bigTenEast.add(new Team("Michigan State", "Spartans", 2, 4));
            bigTenEast.add(new Team("Rutgers", "Scarlet Knights", 2, 5));

            bigTenWest.add(new Team("Nebraska", "Cornhuskers", 6, 0));
            bigTenWest.add(new Team("Iowa", "Hawkeyes", 5, 2));
            bigTenWest.add(new Team("Wisconsin", "Badgers", 4, 2));
            bigTenWest.add(new Team("Minnesota", "Golden Gophers", 4, 2));
            bigTenWest.add(new Team("Northwestern", "Wildcats", 3, 3));
            bigTenWest.add(new Team("Purdue", "Boilermakers", 3, 3));
            bigTenWest.add(new Team("Illinois", "Fighting Illini", 2, 4));

            independents.add(new Team("Army", "Black Knights", 4, 2));
            independents.add(new Team("BYU", "Cougars", 4, 3));
            independents.add(new Team("Notre Dame", "Fighting Irish", 2, 5));
            independents.add(new Team("UMass", "Minutemen", 1, 6));
            InitializeComponent();
        }

        private void display(Football football, string indent)
        {
            tbFootball.Text += "\n" + indent + football.getName() + football.getRecord();
            for(int i = 0; i < football.getNumChildren(); i++)
            {
                display(football.getChild(i), indent + "   ");
            }
        }

        private void btnAddIndependents_Click(object sender, EventArgs e)
        {
            display(independents, "");
        }

        private void btnAddBigTen_Click(object sender, EventArgs e)
        {
            bigTen.add(bigTenEast);
            bigTen.add(bigTenWest);
            display(bigTen, "");
        }
    }
}
