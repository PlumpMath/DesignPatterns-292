using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FacadePattern
{
    public partial class Form1 : Form
    {
        RoomRemote remote;
        public Form1()
        {
            InitializeComponent();
            remote = new RoomRemote();
        }

        private void btnWakeUp_Click(object sender, EventArgs e)
        {
            remote.wakeUp();
            updateInfo();

            btnLeaveRoom.Enabled = true;
            btnStudy.Enabled = true;
            btnWatchMovie.Enabled = true;
            btnWatchTV.Enabled = true;
        }

        private void updateInfo()
        {
            if (remote.bedroomLights.areOn())
                bedroomLightsLabel.Text = "On";
            else
                bedroomLightsLabel.Text = "Off";

            if (remote.livingRoomLights.areOn())
                livingRoomLightsLabel.Text = "On";
            else
                livingRoomLightsLabel.Text = "Off";

            if (remote.alarm.isOn())
                alarmLabel.Text = remote.alarm.getTime().ToString();
            else
                alarmLabel.Text = "Off";

            if (remote.tv.isOn())
                tvLabel.Text = remote.tv.getInput();
            else
                tvLabel.Text = "Off";

            temperatureLabel.Text = remote.temperatureGauge.getTemp();
        }

        private void btnLeaveRoom_Click(object sender, EventArgs e)
        {
            remote.leaveRoom();
            updateInfo();
        }

        private void btnWatchTV_Click(object sender, EventArgs e)
        {
            remote.watchTV();
            updateInfo();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            remote.study();
            updateInfo();
        }

        private void btnWatchMovie_Click(object sender, EventArgs e)
        {
            remote.watchMovie();
            updateInfo();
        }

        private void btnGoToBed_Click(object sender, EventArgs e)
        {
            remote.goToBed(Double.Parse(tbAlarmTime.Text));
            updateInfo();
            btnLeaveRoom.Enabled = false;
            btnStudy.Enabled = false;
            btnWatchMovie.Enabled = false;
            btnWatchTV.Enabled = false;
        }
    }
}
