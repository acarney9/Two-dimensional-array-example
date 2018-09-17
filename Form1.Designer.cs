namespace StudentAvgTwoDimArray
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.showScoresButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.testAverageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Location = new System.Drawing.Point(105, 60);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(389, 201);
            this.displayLabel.TabIndex = 0;
            // 
            // showScoresButton
            // 
            this.showScoresButton.Location = new System.Drawing.Point(58, 312);
            this.showScoresButton.Name = "showScoresButton";
            this.showScoresButton.Size = new System.Drawing.Size(137, 53);
            this.showScoresButton.TabIndex = 1;
            this.showScoresButton.Text = "Show Scores";
            this.showScoresButton.UseVisualStyleBackColor = true;
            this.showScoresButton.Click += new System.EventHandler(this.showScoresButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(229, 312);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(137, 53);
            this.averageButton.TabIndex = 2;
            this.averageButton.Text = "Show Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // testAverageButton
            // 
            this.testAverageButton.Location = new System.Drawing.Point(399, 312);
            this.testAverageButton.Name = "testAverageButton";
            this.testAverageButton.Size = new System.Drawing.Size(137, 53);
            this.testAverageButton.TabIndex = 3;
            this.testAverageButton.Text = "Test Averages";
            this.testAverageButton.UseVisualStyleBackColor = true;
            this.testAverageButton.Click += new System.EventHandler(this.testAverageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 432);
            this.Controls.Add(this.testAverageButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.showScoresButton);
            this.Controls.Add(this.displayLabel);
            this.Name = "Form1";
            this.Text = "Student Average";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button showScoresButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button testAverageButton;
    }
}

