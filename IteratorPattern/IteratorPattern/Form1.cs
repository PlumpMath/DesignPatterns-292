using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class Form1 : Form
    {
        Aggregate agg = new ConcreteAggregate();
        Iterator eastIterator;
        Iterator westIterator;
        Iterator rankedIterator;
        Iterator winningIterator;

        public Form1()
        {
            InitializeComponent();
            establishIteratorPattern();
        }

        private void establishIteratorPattern()
        {
            agg.add(new Team("Illinois", 5, 7, "NR", "Big Ten West"));
            agg.add(new Team("Indiana", 6, 7, "NR", "Big Ten East"));
            agg.add(new Team("Iowa", 12, 2, "17", "Big Ten West"));
            agg.add(new Team("Maryland", 3, 9, "NR", "Big Ten East"));
            agg.add(new Team("Michigan", 10, 3, "7", "Big Ten East"));
            agg.add(new Team("Michigan State", 12, 2, "12", "Big Ten East"));
            agg.add(new Team("Minnesota", 6, 7, "NR", "Big Ten West"));
            agg.add(new Team("Nebraska", 6, 7, "RV", "Big Ten West"));
            agg.add(new Team("Northwestern", 10, 3, "NR", "Big Ten West"));
            agg.add(new Team("Ohio State", 12, 1, "6", "Big Ten East"));
            agg.add(new Team("Penn State", 7, 6, "NR", "Big Ten East"));
            agg.add(new Team("Purdue", 2, 10, "NR", "Big Ten West"));
            agg.add(new Team("Rutgers", 4, 8, "NR", "Big Ten East"));
            agg.add(new Team("Wisconsin", 10, 3, "RV", "Big Ten West"));

            westIterator = agg.createIterator("West");
            eastIterator = agg.createIterator("East");
            rankedIterator = agg.createIterator("Ranked");
            winningIterator = agg.createIterator("Winning");
        }

        private void btnIterateEast_Click(object sender, EventArgs e)
        {
            lbElements.Items.Clear();
            for (eastIterator.first(); !eastIterator.isDone(); eastIterator.next())
                lbElements.Items.Add(eastIterator.currentItem().getName());
        }

        private void btnIterateWest_Click(object sender, EventArgs e)
        {
            lbElements.Items.Clear();
            for (westIterator.first(); !westIterator.isDone(); westIterator.next())
                lbElements.Items.Add(westIterator.currentItem().getName());
        }

        private void btnIterateRanked_Click(object sender, EventArgs e)
        {
            lbElements.Items.Clear();
            for (rankedIterator.first(); !rankedIterator.isDone(); rankedIterator.next())
                lbElements.Items.Add("#" + rankedIterator.currentItem().getRank() + " " + rankedIterator.currentItem().getName());
        }

        private void btnIterateWinning_Click(object sender, EventArgs e)
        {
            lbElements.Items.Clear();
            for (winningIterator.first(); !winningIterator.isDone(); winningIterator.next())
                lbElements.Items.Add(winningIterator.currentItem().getName() + " " + winningIterator.currentItem().getWins() + "-" + winningIterator.currentItem().getLosses());
        }
    }
}
