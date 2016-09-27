using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
        private CreateComicCharacter factory;
        private ComicCharacter character;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateHero_Click(object sender, EventArgs e)
        {
            factory = new CreateHero(tbHeroName.Text, tbHeroPowers.Text, tbHeroCity.Text, tbHeroOrigin.Text);
            character = factory.createCharacter();
            tbHeroesAndVillains.Text += character.getSummary() + "\n \n";
        }

        private void btnCreateVillain_Click(object sender, EventArgs e)
        {
            factory = new CreateVillain(tbVillainName.Text, tbVillainPowers.Text, tbVillainMotive.Text, tbVillainRival.Text);
            character = factory.createCharacter();
            tbHeroesAndVillains.Text += character.getSummary() + "\n \n";
        }
    }
}
