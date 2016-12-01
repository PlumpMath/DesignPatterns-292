namespace DecoratorPattern
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbStrenght = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.cbFlying = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbHeroes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 59);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Superhero";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbStrenght
            // 
            this.cbStrenght.AutoSize = true;
            this.cbStrenght.Location = new System.Drawing.Point(152, 20);
            this.cbStrenght.Name = "cbStrenght";
            this.cbStrenght.Size = new System.Drawing.Size(92, 17);
            this.cbStrenght.TabIndex = 1;
            this.cbStrenght.Text = "Superstrength";
            this.cbStrenght.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Name";
            // 
            // cbSpeed
            // 
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Location = new System.Drawing.Point(152, 43);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(83, 17);
            this.cbSpeed.TabIndex = 1;
            this.cbSpeed.Text = "Superspeed";
            this.cbSpeed.UseVisualStyleBackColor = true;
            // 
            // cbFlying
            // 
            this.cbFlying.AutoSize = true;
            this.cbFlying.Location = new System.Drawing.Point(152, 65);
            this.cbFlying.Name = "cbFlying";
            this.cbFlying.Size = new System.Drawing.Size(53, 17);
            this.cbFlying.TabIndex = 1;
            this.cbFlying.Text = "Flying";
            this.cbFlying.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(152, 88);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(90, 17);
            this.cbOther.TabIndex = 1;
            this.cbOther.Text = "Other Abilities";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(272, 88);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(141, 20);
            this.tbOther.TabIndex = 3;
            this.tbOther.Text = "Ablities";
            // 
            // tbStrength
            // 
            this.tbStrength.Location = new System.Drawing.Point(272, 20);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.Size = new System.Drawing.Size(141, 20);
            this.tbStrength.TabIndex = 3;
            this.tbStrength.Text = "Strength Level";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(272, 43);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(141, 20);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Text = "Speed Level";
            // 
            // tbHeroes
            // 
            this.tbHeroes.Location = new System.Drawing.Point(13, 128);
            this.tbHeroes.Name = "tbHeroes";
            this.tbHeroes.Size = new System.Drawing.Size(400, 176);
            this.tbHeroes.TabIndex = 4;
            this.tbHeroes.Text = "";
            this.tbHeroes.TextChanged += new System.EventHandler(this.tbHeroes_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 316);
            this.Controls.Add(this.tbHeroes);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbStrength);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbFlying);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.cbStrenght);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox cbStrenght;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbSpeed;
        private System.Windows.Forms.CheckBox cbFlying;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.RichTextBox tbHeroes;
    }
}

