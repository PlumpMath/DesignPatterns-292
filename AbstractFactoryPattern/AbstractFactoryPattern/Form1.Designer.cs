namespace AbstractFactoryPattern
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
            this.btnCreateHero = new System.Windows.Forms.Button();
            this.btnCreateVillain = new System.Windows.Forms.Button();
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.tbHeroCity = new System.Windows.Forms.TextBox();
            this.tbVillainName = new System.Windows.Forms.TextBox();
            this.tbVillainRival = new System.Windows.Forms.TextBox();
            this.tbHeroPowers = new System.Windows.Forms.RichTextBox();
            this.tbHeroOrigin = new System.Windows.Forms.RichTextBox();
            this.tbVillainPowers = new System.Windows.Forms.RichTextBox();
            this.tbVillainMotive = new System.Windows.Forms.RichTextBox();
            this.tbHeroesAndVillains = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCreateHero
            // 
            this.btnCreateHero.Location = new System.Drawing.Point(12, 228);
            this.btnCreateHero.Name = "btnCreateHero";
            this.btnCreateHero.Size = new System.Drawing.Size(100, 23);
            this.btnCreateHero.TabIndex = 0;
            this.btnCreateHero.Text = "Create Hero";
            this.btnCreateHero.UseVisualStyleBackColor = true;
            this.btnCreateHero.Click += new System.EventHandler(this.btnCreateHero_Click);
            // 
            // btnCreateVillain
            // 
            this.btnCreateVillain.Location = new System.Drawing.Point(199, 228);
            this.btnCreateVillain.Name = "btnCreateVillain";
            this.btnCreateVillain.Size = new System.Drawing.Size(100, 23);
            this.btnCreateVillain.TabIndex = 1;
            this.btnCreateVillain.Text = "Create Villain";
            this.btnCreateVillain.UseVisualStyleBackColor = true;
            this.btnCreateVillain.Click += new System.EventHandler(this.btnCreateVillain_Click);
            // 
            // tbHeroName
            // 
            this.tbHeroName.Location = new System.Drawing.Point(12, 12);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbHeroName.Size = new System.Drawing.Size(100, 20);
            this.tbHeroName.TabIndex = 2;
            this.tbHeroName.Text = "Name";
            // 
            // tbHeroCity
            // 
            this.tbHeroCity.Location = new System.Drawing.Point(12, 38);
            this.tbHeroCity.Name = "tbHeroCity";
            this.tbHeroCity.Size = new System.Drawing.Size(100, 20);
            this.tbHeroCity.TabIndex = 4;
            this.tbHeroCity.Text = "City";
            // 
            // tbVillainName
            // 
            this.tbVillainName.Location = new System.Drawing.Point(199, 12);
            this.tbVillainName.Name = "tbVillainName";
            this.tbVillainName.Size = new System.Drawing.Size(100, 20);
            this.tbVillainName.TabIndex = 3;
            this.tbVillainName.Text = "Name";
            // 
            // tbVillainRival
            // 
            this.tbVillainRival.Location = new System.Drawing.Point(199, 38);
            this.tbVillainRival.Name = "tbVillainRival";
            this.tbVillainRival.Size = new System.Drawing.Size(100, 20);
            this.tbVillainRival.TabIndex = 3;
            this.tbVillainRival.Text = "Rival Hero";
            // 
            // tbHeroPowers
            // 
            this.tbHeroPowers.Location = new System.Drawing.Point(12, 64);
            this.tbHeroPowers.Name = "tbHeroPowers";
            this.tbHeroPowers.Size = new System.Drawing.Size(100, 76);
            this.tbHeroPowers.TabIndex = 5;
            this.tbHeroPowers.Text = "Powers";
            // 
            // tbHeroOrigin
            // 
            this.tbHeroOrigin.Location = new System.Drawing.Point(12, 146);
            this.tbHeroOrigin.Name = "tbHeroOrigin";
            this.tbHeroOrigin.Size = new System.Drawing.Size(100, 76);
            this.tbHeroOrigin.TabIndex = 5;
            this.tbHeroOrigin.Text = "Origin";
            // 
            // tbVillainPowers
            // 
            this.tbVillainPowers.Location = new System.Drawing.Point(199, 64);
            this.tbVillainPowers.Name = "tbVillainPowers";
            this.tbVillainPowers.Size = new System.Drawing.Size(100, 76);
            this.tbVillainPowers.TabIndex = 5;
            this.tbVillainPowers.Text = "Powers";
            // 
            // tbVillainMotive
            // 
            this.tbVillainMotive.Location = new System.Drawing.Point(199, 146);
            this.tbVillainMotive.Name = "tbVillainMotive";
            this.tbVillainMotive.Size = new System.Drawing.Size(100, 76);
            this.tbVillainMotive.TabIndex = 5;
            this.tbVillainMotive.Text = "Motive";
            // 
            // tbHeroesAndVillains
            // 
            this.tbHeroesAndVillains.Location = new System.Drawing.Point(13, 258);
            this.tbHeroesAndVillains.Name = "tbHeroesAndVillains";
            this.tbHeroesAndVillains.Size = new System.Drawing.Size(286, 162);
            this.tbHeroesAndVillains.TabIndex = 6;
            this.tbHeroesAndVillains.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 432);
            this.Controls.Add(this.tbHeroesAndVillains);
            this.Controls.Add(this.tbVillainMotive);
            this.Controls.Add(this.tbVillainPowers);
            this.Controls.Add(this.tbHeroOrigin);
            this.Controls.Add(this.tbHeroPowers);
            this.Controls.Add(this.tbHeroCity);
            this.Controls.Add(this.tbVillainRival);
            this.Controls.Add(this.tbVillainName);
            this.Controls.Add(this.tbHeroName);
            this.Controls.Add(this.btnCreateVillain);
            this.Controls.Add(this.btnCreateHero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHero;
        private System.Windows.Forms.Button btnCreateVillain;
        private System.Windows.Forms.TextBox tbHeroName;
        private System.Windows.Forms.TextBox tbHeroCity;
        private System.Windows.Forms.TextBox tbVillainName;
        private System.Windows.Forms.TextBox tbVillainRival;
        private System.Windows.Forms.RichTextBox tbHeroPowers;
        private System.Windows.Forms.RichTextBox tbHeroOrigin;
        private System.Windows.Forms.RichTextBox tbVillainPowers;
        private System.Windows.Forms.RichTextBox tbVillainMotive;
        private System.Windows.Forms.RichTextBox tbHeroesAndVillains;
    }
}

