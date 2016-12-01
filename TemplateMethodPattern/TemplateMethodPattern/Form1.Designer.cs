namespace TemplateMethodPattern
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
            this.cbFoods = new System.Windows.Forms.ComboBox();
            this.btnEat = new System.Windows.Forms.Button();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbFoods
            // 
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.Items.AddRange(new object[] {
            "Soup",
            "Sandwich",
            "Pasta"});
            this.cbFoods.Location = new System.Drawing.Point(12, 41);
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(121, 21);
            this.cbFoods.TabIndex = 0;
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(12, 12);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(75, 23);
            this.btnEat.TabIndex = 1;
            this.btnEat.Text = "Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(172, 15);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(100, 20);
            this.tbFoodName.TabIndex = 2;
            this.tbFoodName.Text = "Food Name";
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(12, 125);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.Size = new System.Drawing.Size(260, 205);
            this.rtbSummary.TabIndex = 3;
            this.rtbSummary.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.tbFoodName);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.cbFoods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFoods;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.RichTextBox rtbSummary;
    }
}

