namespace Distance_Converter_Project
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
            this.distanceToConvertLabel = new System.Windows.Forms.Label();
            this.originalDistanceTextBox = new System.Windows.Forms.TextBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.convertedDistanceTextLabel = new System.Windows.Forms.Label();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // distanceToConvertLabel
            // 
            this.distanceToConvertLabel.AutoSize = true;
            this.distanceToConvertLabel.Location = new System.Drawing.Point(61, 36);
            this.distanceToConvertLabel.Name = "distanceToConvertLabel";
            this.distanceToConvertLabel.Size = new System.Drawing.Size(138, 13);
            this.distanceToConvertLabel.TabIndex = 0;
            this.distanceToConvertLabel.Text = "Enter a distance to convert:";
            // 
            // originalDistanceTextBox
            // 
            this.originalDistanceTextBox.Location = new System.Drawing.Point(228, 33);
            this.originalDistanceTextBox.Name = "originalDistanceTextBox";
            this.originalDistanceTextBox.Size = new System.Drawing.Size(148, 20);
            this.originalDistanceTextBox.TabIndex = 1;
            // 
            // fromListBox
            // 
            this.fromListBox.AccessibleName = "";
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(29, 35);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(101, 43);
            this.fromListBox.TabIndex = 2;
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(31, 35);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(109, 43);
            this.toListBox.TabIndex = 3;
            // 
            // convertedDistanceTextLabel
            // 
            this.convertedDistanceTextLabel.AutoSize = true;
            this.convertedDistanceTextLabel.Location = new System.Drawing.Point(95, 201);
            this.convertedDistanceTextLabel.Name = "convertedDistanceTextLabel";
            this.convertedDistanceTextLabel.Size = new System.Drawing.Size(104, 13);
            this.convertedDistanceTextLabel.TabIndex = 4;
            this.convertedDistanceTextLabel.Text = "Converted Distance:";
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceLabel.Location = new System.Drawing.Point(228, 196);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(148, 23);
            this.convertedDistanceLabel.TabIndex = 5;
            this.convertedDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(124, 235);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 235);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromListBox);
            this.groupBox1.Location = new System.Drawing.Point(40, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toListBox);
            this.groupBox2.Location = new System.Drawing.Point(217, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.convertedDistanceTextLabel);
            this.Controls.Add(this.originalDistanceTextBox);
            this.Controls.Add(this.distanceToConvertLabel);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distanceToConvertLabel;
        private System.Windows.Forms.TextBox originalDistanceTextBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label convertedDistanceTextLabel;
        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

