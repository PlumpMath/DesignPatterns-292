using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        public int teamAscore = 0;
        public int teamBscore = 0;
        public delegate void ScoreChangedEventHandler(object sender, ScoreChangedEventArgs e);
        public event ScoreChangedEventHandler ScoreChanged;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTDA_Click(object sender, EventArgs e)
        {
            teamAscore += 6;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamA.Text, 6));
        }

        private void btnTDB_Click(object sender, EventArgs e)
        {
            teamBscore += 6;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamB.Text, 6));
        }

        private void btnFGA_Click(object sender, EventArgs e)
        {
            teamAscore += 3;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamA.Text, 3));
        }
        
        private void btnFGB_Click(object sender, EventArgs e)
        {
            teamBscore += 3;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamB.Text, 3));
        }

        private void btn2ptA_Click(object sender, EventArgs e)
        {
            teamAscore += 2;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamA.Text, 2));
        }

        private void btn2ptB_Click(object sender, EventArgs e)
        {
            teamBscore += 2;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamB.Text, 2));
        }

        private void btnXPA_Click(object sender, EventArgs e)
        {
            teamAscore += 1;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamA.Text, 1));
        }

        private void btnXPB_Click(object sender, EventArgs e)
        {
            teamBscore += 1;
            scoreChanged(this, new ScoreChangedEventArgs(tbTeamB.Text, 1));
        }

        void scoreChanged(object sender, ScoreChangedEventArgs e)
        {
            MessageBox.Show(e.getName() + " scored " + e.getScore());
            scoreLabel.Text = teamAscore + " - " + teamBscore;
        }
    }
}
