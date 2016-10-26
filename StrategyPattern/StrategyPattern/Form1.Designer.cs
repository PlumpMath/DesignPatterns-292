namespace StrategyPattern
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbNumOne = new System.Windows.Forms.TextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.tbNumTwo = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(294, 13);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbNumOne
            // 
            this.tbNumOne.Location = new System.Drawing.Point(13, 14);
            this.tbNumOne.Name = "tbNumOne";
            this.tbNumOne.Size = new System.Drawing.Size(71, 20);
            this.tbNumOne.TabIndex = 1;
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(90, 14);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 21);
            this.cbOperation.TabIndex = 2;
            // 
            // tbNumTwo
            // 
            this.tbNumTwo.Location = new System.Drawing.Point(217, 15);
            this.tbNumTwo.Name = "tbNumTwo";
            this.tbNumTwo.Size = new System.Drawing.Size(71, 20);
            this.tbNumTwo.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(304, 50);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 94);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.tbNumTwo);
            this.Controls.Add(this.tbNumOne);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbNumOne;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.TextBox tbNumTwo;
        private System.Windows.Forms.Label labelResult;
    }
}

