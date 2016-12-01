namespace BridgePattern
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
            this.toastBtn = new System.Windows.Forms.Button();
            this.tbFood = new System.Windows.Forms.TextBox();
            this.microwaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toastBtn
            // 
            this.toastBtn.Location = new System.Drawing.Point(165, 48);
            this.toastBtn.Name = "toastBtn";
            this.toastBtn.Size = new System.Drawing.Size(75, 23);
            this.toastBtn.TabIndex = 1;
            this.toastBtn.Text = "Toast";
            this.toastBtn.UseVisualStyleBackColor = true;
            this.toastBtn.Click += new System.EventHandler(this.toastBtn_Click);
            // 
            // tbFood
            // 
            this.tbFood.Location = new System.Drawing.Point(12, 30);
            this.tbFood.Name = "tbFood";
            this.tbFood.Size = new System.Drawing.Size(100, 20);
            this.tbFood.TabIndex = 2;
            this.tbFood.Text = "Food";
            // 
            // microwaveBtn
            // 
            this.microwaveBtn.Location = new System.Drawing.Point(165, 13);
            this.microwaveBtn.Name = "microwaveBtn";
            this.microwaveBtn.Size = new System.Drawing.Size(75, 23);
            this.microwaveBtn.TabIndex = 3;
            this.microwaveBtn.Text = "Microwave";
            this.microwaveBtn.UseVisualStyleBackColor = true;
            this.microwaveBtn.Click += new System.EventHandler(this.microwaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 83);
            this.Controls.Add(this.microwaveBtn);
            this.Controls.Add(this.tbFood);
            this.Controls.Add(this.toastBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toastBtn;
        private System.Windows.Forms.TextBox tbFood;
        private System.Windows.Forms.Button microwaveBtn;
    }
}

