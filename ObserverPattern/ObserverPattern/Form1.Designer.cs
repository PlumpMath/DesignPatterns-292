namespace ObserverPattern
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
            this.tbTeamA = new System.Windows.Forms.TextBox();
            this.tbTeamB = new System.Windows.Forms.TextBox();
            this.btnTDA = new System.Windows.Forms.Button();
            this.btnFGA = new System.Windows.Forms.Button();
            this.btn2ptA = new System.Windows.Forms.Button();
            this.btnTDB = new System.Windows.Forms.Button();
            this.btnFGB = new System.Windows.Forms.Button();
            this.btn2ptB = new System.Windows.Forms.Button();
            this.btnXPA = new System.Windows.Forms.Button();
            this.btnXPB = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // tbTeamA
            // 
            this.tbTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamA.Location = new System.Drawing.Point(12, 54);
            this.tbTeamA.Name = "tbTeamA";
            this.tbTeamA.Size = new System.Drawing.Size(74, 26);
            this.tbTeamA.TabIndex = 1;
            this.tbTeamA.Text = "Team A";
            // 
            // tbTeamB
            // 
            this.tbTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamB.Location = new System.Drawing.Point(251, 54);
            this.tbTeamB.Name = "tbTeamB";
            this.tbTeamB.Size = new System.Drawing.Size(74, 26);
            this.tbTeamB.TabIndex = 1;
            this.tbTeamB.Text = "Team B";
            // 
            // btnTDA
            // 
            this.btnTDA.Location = new System.Drawing.Point(12, 120);
            this.btnTDA.Name = "btnTDA";
            this.btnTDA.Size = new System.Drawing.Size(75, 23);
            this.btnTDA.TabIndex = 2;
            this.btnTDA.Text = "Touchdown";
            this.btnTDA.UseVisualStyleBackColor = true;
            this.btnTDA.Click += new System.EventHandler(this.btnTDA_Click);
            // 
            // btnFGA
            // 
            this.btnFGA.Location = new System.Drawing.Point(12, 168);
            this.btnFGA.Name = "btnFGA";
            this.btnFGA.Size = new System.Drawing.Size(75, 23);
            this.btnFGA.TabIndex = 3;
            this.btnFGA.Text = "Field Goal";
            this.btnFGA.UseVisualStyleBackColor = true;
            this.btnFGA.Click += new System.EventHandler(this.btnFGA_Click);
            // 
            // btn2ptA
            // 
            this.btn2ptA.Location = new System.Drawing.Point(12, 219);
            this.btn2ptA.Name = "btn2ptA";
            this.btn2ptA.Size = new System.Drawing.Size(75, 23);
            this.btn2ptA.TabIndex = 4;
            this.btn2ptA.Text = "Safety / 2pt";
            this.btn2ptA.UseVisualStyleBackColor = true;
            this.btn2ptA.Click += new System.EventHandler(this.btn2ptA_Click);
            // 
            // btnTDB
            // 
            this.btnTDB.Location = new System.Drawing.Point(250, 120);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(75, 23);
            this.btnTDB.TabIndex = 2;
            this.btnTDB.Text = "Touchdown";
            this.btnTDB.UseVisualStyleBackColor = true;
            this.btnTDB.Click += new System.EventHandler(this.btnTDB_Click);
            // 
            // btnFGB
            // 
            this.btnFGB.Location = new System.Drawing.Point(251, 168);
            this.btnFGB.Name = "btnFGB";
            this.btnFGB.Size = new System.Drawing.Size(75, 23);
            this.btnFGB.TabIndex = 2;
            this.btnFGB.Text = "Field Goal";
            this.btnFGB.UseVisualStyleBackColor = true;
            this.btnFGB.Click += new System.EventHandler(this.btnFGB_Click);
            // 
            // btn2ptB
            // 
            this.btn2ptB.Location = new System.Drawing.Point(250, 219);
            this.btn2ptB.Name = "btn2ptB";
            this.btn2ptB.Size = new System.Drawing.Size(75, 23);
            this.btn2ptB.TabIndex = 2;
            this.btn2ptB.Text = "Safety / 2pt";
            this.btn2ptB.UseVisualStyleBackColor = true;
            this.btn2ptB.Click += new System.EventHandler(this.btn2ptB_Click);
            // 
            // btnXPA
            // 
            this.btnXPA.Location = new System.Drawing.Point(12, 271);
            this.btnXPA.Name = "btnXPA";
            this.btnXPA.Size = new System.Drawing.Size(75, 23);
            this.btnXPA.TabIndex = 4;
            this.btnXPA.Text = "Extra Point";
            this.btnXPA.UseVisualStyleBackColor = true;
            this.btnXPA.Click += new System.EventHandler(this.btnXPA_Click);
            // 
            // btnXPB
            // 
            this.btnXPB.Location = new System.Drawing.Point(250, 271);
            this.btnXPB.Name = "btnXPB";
            this.btnXPB.Size = new System.Drawing.Size(75, 23);
            this.btnXPB.TabIndex = 2;
            this.btnXPB.Text = "Extra Point";
            this.btnXPB.UseVisualStyleBackColor = true;
            this.btnXPB.Click += new System.EventHandler(this.btnXPB_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(145, 57);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(40, 20);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "0 - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.btnXPA);
            this.Controls.Add(this.btn2ptA);
            this.Controls.Add(this.btnFGA);
            this.Controls.Add(this.btnXPB);
            this.Controls.Add(this.btn2ptB);
            this.Controls.Add(this.btnFGB);
            this.Controls.Add(this.btnTDB);
            this.Controls.Add(this.btnTDA);
            this.Controls.Add(this.tbTeamB);
            this.Controls.Add(this.tbTeamA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTDA;
        private System.Windows.Forms.Button btnFGA;
        private System.Windows.Forms.Button btn2ptA;
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnFGB;
        private System.Windows.Forms.Button btn2ptB;
        private System.Windows.Forms.Button btnXPA;
        private System.Windows.Forms.Button btnXPB;
        public System.Windows.Forms.Label scoreLabel;
        public System.Windows.Forms.TextBox tbTeamA;
        public System.Windows.Forms.TextBox tbTeamB;
    }
}

