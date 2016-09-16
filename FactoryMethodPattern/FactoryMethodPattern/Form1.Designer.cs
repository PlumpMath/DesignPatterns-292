namespace FactoryMethodPattern
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
            this.btnCreateTextFile = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnCSVFile = new System.Windows.Forms.Button();
            this.tbUserText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTextFile
            // 
            this.btnCreateTextFile.Location = new System.Drawing.Point(24, 202);
            this.btnCreateTextFile.Name = "btnCreateTextFile";
            this.btnCreateTextFile.Size = new System.Drawing.Size(97, 23);
            this.btnCreateTextFile.TabIndex = 0;
            this.btnCreateTextFile.Text = "Create Text File";
            this.btnCreateTextFile.UseVisualStyleBackColor = true;
            this.btnCreateTextFile.Click += new System.EventHandler(this.btnCreateTextFile_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(182, 146);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(97, 20);
            this.tbFileName.TabIndex = 1;
            // 
            // btnCSVFile
            // 
            this.btnCSVFile.Location = new System.Drawing.Point(182, 202);
            this.btnCSVFile.Name = "btnCSVFile";
            this.btnCSVFile.Size = new System.Drawing.Size(97, 23);
            this.btnCSVFile.TabIndex = 2;
            this.btnCSVFile.Text = "Create CSV File";
            this.btnCSVFile.UseVisualStyleBackColor = true;
            this.btnCSVFile.Click += new System.EventHandler(this.btnCSVFile_Click);
            // 
            // tbUserText
            // 
            this.tbUserText.Location = new System.Drawing.Point(24, 28);
            this.tbUserText.Name = "tbUserText";
            this.tbUserText.Size = new System.Drawing.Size(255, 96);
            this.tbUserText.TabIndex = 3;
            this.tbUserText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name Of File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Text To Go Into File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserText);
            this.Controls.Add(this.btnCSVFile);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnCreateTextFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTextFile;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnCSVFile;
        private System.Windows.Forms.RichTextBox tbUserText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

