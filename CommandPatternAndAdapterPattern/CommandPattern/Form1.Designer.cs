namespace CommandPattern
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
            this.btnAddText = new System.Windows.Forms.Button();
            this.tbTextInput = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.tbAllText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(12, 41);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(75, 23);
            this.btnAddText.TabIndex = 0;
            this.btnAddText.Text = "Add Number";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // tbTextInput
            // 
            this.tbTextInput.Location = new System.Drawing.Point(13, 14);
            this.tbTextInput.Name = "tbTextInput";
            this.tbTextInput.Size = new System.Drawing.Size(311, 20);
            this.tbTextInput.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(133, 41);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(249, 41);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 2;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // tbAllText
            // 
            this.tbAllText.Location = new System.Drawing.Point(13, 80);
            this.tbAllText.Name = "tbAllText";
            this.tbAllText.Size = new System.Drawing.Size(311, 229);
            this.tbAllText.TabIndex = 3;
            this.tbAllText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 321);
            this.Controls.Add(this.tbAllText);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.tbTextInput);
            this.Controls.Add(this.btnAddText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox tbTextInput;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.RichTextBox tbAllText;
    }
}

