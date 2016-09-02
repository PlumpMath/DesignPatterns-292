namespace IteratorPattern
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
            this.lbElements = new System.Windows.Forms.ListBox();
            this.btnIterateEast = new System.Windows.Forms.Button();
            this.btnIterateWest = new System.Windows.Forms.Button();
            this.btnIterateRanked = new System.Windows.Forms.Button();
            this.btnIterateWinning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.FormattingEnabled = true;
            this.lbElements.Location = new System.Drawing.Point(152, 31);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(120, 186);
            this.lbElements.TabIndex = 1;
            // 
            // btnIterateEast
            // 
            this.btnIterateEast.Location = new System.Drawing.Point(28, 82);
            this.btnIterateEast.Name = "btnIterateEast";
            this.btnIterateEast.Size = new System.Drawing.Size(118, 23);
            this.btnIterateEast.TabIndex = 2;
            this.btnIterateEast.Text = "Iterate Big Ten East";
            this.btnIterateEast.UseVisualStyleBackColor = true;
            this.btnIterateEast.Click += new System.EventHandler(this.btnIterateEast_Click);
            // 
            // btnIterateWest
            // 
            this.btnIterateWest.Location = new System.Drawing.Point(29, 31);
            this.btnIterateWest.Name = "btnIterateWest";
            this.btnIterateWest.Size = new System.Drawing.Size(117, 23);
            this.btnIterateWest.TabIndex = 3;
            this.btnIterateWest.Text = "Iterate Big Ten West";
            this.btnIterateWest.UseVisualStyleBackColor = true;
            this.btnIterateWest.Click += new System.EventHandler(this.btnIterateWest_Click);
            // 
            // btnIterateRanked
            // 
            this.btnIterateRanked.Location = new System.Drawing.Point(13, 140);
            this.btnIterateRanked.Name = "btnIterateRanked";
            this.btnIterateRanked.Size = new System.Drawing.Size(133, 23);
            this.btnIterateRanked.TabIndex = 4;
            this.btnIterateRanked.Text = "Iterate Ranked Teams";
            this.btnIterateRanked.UseVisualStyleBackColor = true;
            this.btnIterateRanked.Click += new System.EventHandler(this.btnIterateRanked_Click);
            // 
            // btnIterateWinning
            // 
            this.btnIterateWinning.Location = new System.Drawing.Point(13, 194);
            this.btnIterateWinning.Name = "btnIterateWinning";
            this.btnIterateWinning.Size = new System.Drawing.Size(133, 23);
            this.btnIterateWinning.TabIndex = 5;
            this.btnIterateWinning.Text = "Iterate Winning Teams";
            this.btnIterateWinning.UseVisualStyleBackColor = true;
            this.btnIterateWinning.Click += new System.EventHandler(this.btnIterateWinning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnIterateWinning);
            this.Controls.Add(this.btnIterateRanked);
            this.Controls.Add(this.btnIterateWest);
            this.Controls.Add(this.btnIterateEast);
            this.Controls.Add(this.lbElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Button btnIterateEast;
        private System.Windows.Forms.Button btnIterateWest;
        private System.Windows.Forms.Button btnIterateRanked;
        private System.Windows.Forms.Button btnIterateWinning;
    }
}

