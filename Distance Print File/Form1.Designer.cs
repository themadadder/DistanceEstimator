namespace Distance_Calculator
{
    partial class distanceCalculator
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
            this.vehicleSpeedLabel = new System.Windows.Forms.Label();
            this.mphTextbox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleSpeedLabel
            // 
            this.vehicleSpeedLabel.AutoSize = true;
            this.vehicleSpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.vehicleSpeedLabel.Name = "vehicleSpeedLabel";
            this.vehicleSpeedLabel.Size = new System.Drawing.Size(117, 13);
            this.vehicleSpeedLabel.TabIndex = 0;
            this.vehicleSpeedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // mphTextbox
            // 
            this.mphTextbox.Location = new System.Drawing.Point(135, 6);
            this.mphTextbox.Name = "mphTextbox";
            this.mphTextbox.Size = new System.Drawing.Size(100, 20);
            this.mphTextbox.TabIndex = 1;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(46, 39);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(83, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours Traveled:";
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Location = new System.Drawing.Point(135, 36);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextbox.TabIndex = 3;
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 59);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(223, 225);
            this.outputBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 287);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(161, 287);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // distanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 322);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.hoursTextbox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.mphTextbox);
            this.Controls.Add(this.vehicleSpeedLabel);
            this.Name = "distanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedLabel;
        private System.Windows.Forms.TextBox mphTextbox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button closeButton;
    }
}

