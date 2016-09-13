namespace FacadePattern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bedroomLightsLabel = new System.Windows.Forms.Label();
            this.livingRoomLightsLabel = new System.Windows.Forms.Label();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.tvLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.btnLeaveRoom = new System.Windows.Forms.Button();
            this.btnGoToBed = new System.Windows.Forms.Button();
            this.btnWakeUp = new System.Windows.Forms.Button();
            this.btnWatchTV = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnWatchMovie = new System.Windows.Forms.Button();
            this.tbAlarmTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bedroom Lights:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Living Room Lights:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alarm Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TV Input:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Temperature Gauge:";
            // 
            // bedroomLightsLabel
            // 
            this.bedroomLightsLabel.AutoSize = true;
            this.bedroomLightsLabel.Location = new System.Drawing.Point(124, 9);
            this.bedroomLightsLabel.Name = "bedroomLightsLabel";
            this.bedroomLightsLabel.Size = new System.Drawing.Size(21, 13);
            this.bedroomLightsLabel.TabIndex = 1;
            this.bedroomLightsLabel.Text = "Off";
            // 
            // livingRoomLightsLabel
            // 
            this.livingRoomLightsLabel.AutoSize = true;
            this.livingRoomLightsLabel.Location = new System.Drawing.Point(124, 38);
            this.livingRoomLightsLabel.Name = "livingRoomLightsLabel";
            this.livingRoomLightsLabel.Size = new System.Drawing.Size(21, 13);
            this.livingRoomLightsLabel.TabIndex = 1;
            this.livingRoomLightsLabel.Text = "Off";
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Location = new System.Drawing.Point(124, 70);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(21, 13);
            this.alarmLabel.TabIndex = 1;
            this.alarmLabel.Text = "Off";
            // 
            // tvLabel
            // 
            this.tvLabel.AutoSize = true;
            this.tvLabel.Location = new System.Drawing.Point(124, 101);
            this.tvLabel.Name = "tvLabel";
            this.tvLabel.Size = new System.Drawing.Size(21, 13);
            this.tvLabel.TabIndex = 1;
            this.tvLabel.Text = "Off";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(124, 133);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(21, 13);
            this.temperatureLabel.TabIndex = 1;
            this.temperatureLabel.Text = "Off";
            // 
            // btnLeaveRoom
            // 
            this.btnLeaveRoom.Location = new System.Drawing.Point(12, 206);
            this.btnLeaveRoom.Name = "btnLeaveRoom";
            this.btnLeaveRoom.Size = new System.Drawing.Size(105, 23);
            this.btnLeaveRoom.TabIndex = 2;
            this.btnLeaveRoom.Text = "Leave Room";
            this.btnLeaveRoom.UseVisualStyleBackColor = true;
            this.btnLeaveRoom.Click += new System.EventHandler(this.btnLeaveRoom_Click);
            // 
            // btnGoToBed
            // 
            this.btnGoToBed.Location = new System.Drawing.Point(12, 285);
            this.btnGoToBed.Name = "btnGoToBed";
            this.btnGoToBed.Size = new System.Drawing.Size(105, 23);
            this.btnGoToBed.TabIndex = 2;
            this.btnGoToBed.Text = "Go To Bed";
            this.btnGoToBed.UseVisualStyleBackColor = true;
            this.btnGoToBed.Click += new System.EventHandler(this.btnGoToBed_Click);
            // 
            // btnWakeUp
            // 
            this.btnWakeUp.Location = new System.Drawing.Point(12, 166);
            this.btnWakeUp.Name = "btnWakeUp";
            this.btnWakeUp.Size = new System.Drawing.Size(220, 23);
            this.btnWakeUp.TabIndex = 2;
            this.btnWakeUp.Text = "Wake Up";
            this.btnWakeUp.UseVisualStyleBackColor = true;
            this.btnWakeUp.Click += new System.EventHandler(this.btnWakeUp_Click);
            // 
            // btnWatchTV
            // 
            this.btnWatchTV.Location = new System.Drawing.Point(127, 206);
            this.btnWatchTV.Name = "btnWatchTV";
            this.btnWatchTV.Size = new System.Drawing.Size(105, 23);
            this.btnWatchTV.TabIndex = 2;
            this.btnWatchTV.Text = "Watch TV";
            this.btnWatchTV.UseVisualStyleBackColor = true;
            this.btnWatchTV.Click += new System.EventHandler(this.btnWatchTV_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.Location = new System.Drawing.Point(13, 246);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(105, 23);
            this.btnStudy.TabIndex = 2;
            this.btnStudy.Text = "Study";
            this.btnStudy.UseVisualStyleBackColor = true;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnWatchMovie
            // 
            this.btnWatchMovie.Location = new System.Drawing.Point(127, 246);
            this.btnWatchMovie.Name = "btnWatchMovie";
            this.btnWatchMovie.Size = new System.Drawing.Size(105, 23);
            this.btnWatchMovie.TabIndex = 2;
            this.btnWatchMovie.Text = "Watch Movie";
            this.btnWatchMovie.UseVisualStyleBackColor = true;
            this.btnWatchMovie.Click += new System.EventHandler(this.btnWatchMovie_Click);
            // 
            // tbAlarmTime
            // 
            this.tbAlarmTime.Location = new System.Drawing.Point(127, 287);
            this.tbAlarmTime.Name = "tbAlarmTime";
            this.tbAlarmTime.Size = new System.Drawing.Size(105, 20);
            this.tbAlarmTime.TabIndex = 3;
            this.tbAlarmTime.Text = "Alarm Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 320);
            this.Controls.Add(this.tbAlarmTime);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnWatchTV);
            this.Controls.Add(this.btnWatchMovie);
            this.Controls.Add(this.btnWakeUp);
            this.Controls.Add(this.btnGoToBed);
            this.Controls.Add(this.btnLeaveRoom);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.tvLabel);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.livingRoomLightsLabel);
            this.Controls.Add(this.bedroomLightsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label bedroomLightsLabel;
        public System.Windows.Forms.Label livingRoomLightsLabel;
        public System.Windows.Forms.Label alarmLabel;
        public System.Windows.Forms.Label tvLabel;
        public System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Button btnLeaveRoom;
        private System.Windows.Forms.Button btnGoToBed;
        private System.Windows.Forms.Button btnWakeUp;
        private System.Windows.Forms.Button btnWatchTV;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnWatchMovie;
        private System.Windows.Forms.TextBox tbAlarmTime;
    }
}

