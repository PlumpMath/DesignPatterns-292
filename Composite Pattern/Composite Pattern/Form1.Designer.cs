namespace Composite_Pattern
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
            this.tbFootball = new System.Windows.Forms.RichTextBox();
            this.btnAddIndependents = new System.Windows.Forms.Button();
            this.btnAddBigTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFootball
            // 
            this.tbFootball.Location = new System.Drawing.Point(13, 13);
            this.tbFootball.Name = "tbFootball";
            this.tbFootball.Size = new System.Drawing.Size(253, 376);
            this.tbFootball.TabIndex = 0;
            this.tbFootball.Text = "";
            // 
            // btnAddIndependents
            // 
            this.btnAddIndependents.Location = new System.Drawing.Point(306, 164);
            this.btnAddIndependents.Name = "btnAddIndependents";
            this.btnAddIndependents.Size = new System.Drawing.Size(108, 23);
            this.btnAddIndependents.TabIndex = 3;
            this.btnAddIndependents.Text = "Add Independents";
            this.btnAddIndependents.UseVisualStyleBackColor = true;
            this.btnAddIndependents.Click += new System.EventHandler(this.btnAddIndependents_Click);
            // 
            // btnAddBigTen
            // 
            this.btnAddBigTen.Location = new System.Drawing.Point(306, 58);
            this.btnAddBigTen.Name = "btnAddBigTen";
            this.btnAddBigTen.Size = new System.Drawing.Size(108, 23);
            this.btnAddBigTen.TabIndex = 4;
            this.btnAddBigTen.Text = "Add Big Ten";
            this.btnAddBigTen.UseVisualStyleBackColor = true;
            this.btnAddBigTen.Click += new System.EventHandler(this.btnAddBigTen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 401);
            this.Controls.Add(this.btnAddBigTen);
            this.Controls.Add(this.btnAddIndependents);
            this.Controls.Add(this.tbFootball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbFootball;
        private System.Windows.Forms.Button btnAddIndependents;
        private System.Windows.Forms.Button btnAddBigTen;
    }
}

