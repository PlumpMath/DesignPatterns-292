using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        private Hero hero;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbHeroes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            hero = new SimpleHero(tbName.Text);

            if (cbStrenght.Checked)
                hero = new StrongHero(hero, tbStrength.Text);
            if (cbSpeed.Checked)
                hero = new FastHero(hero, tbSpeed.Text);
            if (cbFlying.Checked)
                hero = new FlyingHero(hero, null);
            if (cbOther.Checked)
                hero = new OtherHero(hero, tbOther.Text);
            tbHeroes.Text += hero.getName() + hero.getPowers() + "\n";

        }
    }
}
