namespace WordCounter
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
            this.resultlabel = new System.Windows.Forms.Label();
            this.phraseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordCountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.Location = new System.Drawing.Point(504, 37);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(222, 273);
            this.resultlabel.TabIndex = 0;
            this.resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phraseTextBox
            // 
            this.phraseTextBox.Location = new System.Drawing.Point(184, 37);
            this.phraseTextBox.Name = "phraseTextBox";
            this.phraseTextBox.Size = new System.Drawing.Size(257, 20);
            this.phraseTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Phrase";
            // 
            // wordCountButton
            // 
            this.wordCountButton.Location = new System.Drawing.Point(345, 72);
            this.wordCountButton.Name = "wordCountButton";
            this.wordCountButton.Size = new System.Drawing.Size(96, 35);
            this.wordCountButton.TabIndex = 3;
            this.wordCountButton.Text = "Generate Word Count";
            this.wordCountButton.UseVisualStyleBackColor = true;
            this.wordCountButton.Click += new System.EventHandler(this.wordCountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(641, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wordCountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phraseTextBox);
            this.Controls.Add(this.resultlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.TextBox phraseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wordCountButton;
        private System.Windows.Forms.Button exitButton;
    }
}

