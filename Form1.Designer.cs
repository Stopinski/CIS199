namespace Program1
{
    partial class Prog1
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
            this.sqFtTextBox = new System.Windows.Forms.TextBox();
            this.sqFtLabel = new System.Windows.Forms.Label();
            this.coatsNeededTextBox = new System.Windows.Forms.TextBox();
            this.coatsNeededLabel = new System.Windows.Forms.Label();
            this.paintPriceTextBox = new System.Windows.Forms.TextBox();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.totalSqFtOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.paintGallonLabel = new System.Windows.Forms.Label();
            this.paintGallonsOutput = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.laborOutput = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.paintCostOutput = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.laborCostOutput = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.dir1Label = new System.Windows.Forms.Label();
            this.dir2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqFtTextBox
            // 
            this.sqFtTextBox.Location = new System.Drawing.Point(575, 27);
            this.sqFtTextBox.Name = "sqFtTextBox";
            this.sqFtTextBox.Size = new System.Drawing.Size(105, 20);
            this.sqFtTextBox.TabIndex = 0;
            // 
            // sqFtLabel
            // 
            this.sqFtLabel.AutoSize = true;
            this.sqFtLabel.Location = new System.Drawing.Point(390, 30);
            this.sqFtLabel.Name = "sqFtLabel";
            this.sqFtLabel.Size = new System.Drawing.Size(179, 13);
            this.sqFtLabel.TabIndex = 1;
            this.sqFtLabel.Text = "Square Feet of Wall Space Needed:";
            // 
            // coatsNeededTextBox
            // 
            this.coatsNeededTextBox.Location = new System.Drawing.Point(575, 78);
            this.coatsNeededTextBox.Name = "coatsNeededTextBox";
            this.coatsNeededTextBox.Size = new System.Drawing.Size(105, 20);
            this.coatsNeededTextBox.TabIndex = 2;
            // 
            // coatsNeededLabel
            // 
            this.coatsNeededLabel.AutoSize = true;
            this.coatsNeededLabel.Location = new System.Drawing.Point(412, 81);
            this.coatsNeededLabel.Name = "coatsNeededLabel";
            this.coatsNeededLabel.Size = new System.Drawing.Size(157, 13);
            this.coatsNeededLabel.TabIndex = 3;
            this.coatsNeededLabel.Text = "Number of Paint Coats Needed:";
            // 
            // paintPriceTextBox
            // 
            this.paintPriceTextBox.Location = new System.Drawing.Point(575, 129);
            this.paintPriceTextBox.Name = "paintPriceTextBox";
            this.paintPriceTextBox.Size = new System.Drawing.Size(105, 20);
            this.paintPriceTextBox.TabIndex = 4;
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(448, 132);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(121, 13);
            this.paintPriceLabel.TabIndex = 5;
            this.paintPriceLabel.Text = "Cost per Gallon of Paint:";
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(140, 32);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(113, 13);
            this.totalSqFtLabel.TabIndex = 6;
            this.totalSqFtLabel.Text = "Total Square Footage:";
            // 
            // totalSqFtOutput
            // 
            this.totalSqFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutput.Location = new System.Drawing.Point(259, 27);
            this.totalSqFtOutput.Name = "totalSqFtOutput";
            this.totalSqFtOutput.Size = new System.Drawing.Size(105, 20);
            this.totalSqFtOutput.TabIndex = 7;
            this.totalSqFtOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(588, 177);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 25);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // paintGallonLabel
            // 
            this.paintGallonLabel.AutoSize = true;
            this.paintGallonLabel.Location = new System.Drawing.Point(73, 82);
            this.paintGallonLabel.Name = "paintGallonLabel";
            this.paintGallonLabel.Size = new System.Drawing.Size(180, 13);
            this.paintGallonLabel.TabIndex = 9;
            this.paintGallonLabel.Text = "Number of gallons of Paint Required:";
            // 
            // paintGallonsOutput
            // 
            this.paintGallonsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintGallonsOutput.Location = new System.Drawing.Point(259, 78);
            this.paintGallonsOutput.Name = "paintGallonsOutput";
            this.paintGallonsOutput.Size = new System.Drawing.Size(105, 20);
            this.paintGallonsOutput.TabIndex = 10;
            this.paintGallonsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(132, 133);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(121, 13);
            this.laborLabel.TabIndex = 11;
            this.laborLabel.Text = "Hours of Labor Needed:";
            // 
            // laborOutput
            // 
            this.laborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborOutput.Location = new System.Drawing.Point(259, 129);
            this.laborOutput.Name = "laborOutput";
            this.laborOutput.Size = new System.Drawing.Size(105, 20);
            this.laborOutput.TabIndex = 12;
            this.laborOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(156, 177);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(97, 13);
            this.paintCostLabel.TabIndex = 13;
            this.paintCostLabel.Text = "Total Cost of Paint:";
            // 
            // paintCostOutput
            // 
            this.paintCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostOutput.Location = new System.Drawing.Point(259, 172);
            this.paintCostOutput.Name = "paintCostOutput";
            this.paintCostOutput.Size = new System.Drawing.Size(105, 23);
            this.paintCostOutput.TabIndex = 14;
            this.paintCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(187, 230);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(66, 13);
            this.laborCostLabel.TabIndex = 15;
            this.laborCostLabel.Text = "Labor Costs:";
            // 
            // laborCostOutput
            // 
            this.laborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutput.Location = new System.Drawing.Point(259, 225);
            this.laborCostOutput.Name = "laborCostOutput";
            this.laborCostOutput.Size = new System.Drawing.Size(105, 23);
            this.laborCostOutput.TabIndex = 16;
            this.laborCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(195, 278);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 17;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(259, 273);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(105, 23);
            this.totalCostOutput.TabIndex = 18;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dir1Label
            // 
            this.dir1Label.AutoSize = true;
            this.dir1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir1Label.Location = new System.Drawing.Point(12, 333);
            this.dir1Label.Name = "dir1Label";
            this.dir1Label.Size = new System.Drawing.Size(104, 16);
            this.dir1Label.TabIndex = 19;
            this.dir1Label.Text = "DIRECTIONS:";
            this.dir1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dir2Label
            // 
            this.dir2Label.AutoSize = true;
            this.dir2Label.Location = new System.Drawing.Point(122, 335);
            this.dir2Label.Name = "dir2Label";
            this.dir2Label.Size = new System.Drawing.Size(377, 13);
            this.dir2Label.TabIndex = 20;
            this.dir2Label.Text = "Please input data in appropriate white boxes. DO NOT enter negative intergers";
            // 
            // Prog1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(692, 375);
            this.Controls.Add(this.dir2Label);
            this.Controls.Add(this.dir1Label);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostOutput);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostOutput);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.laborOutput);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.paintGallonsOutput);
            this.Controls.Add(this.paintGallonLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalSqFtOutput);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.paintPriceTextBox);
            this.Controls.Add(this.coatsNeededLabel);
            this.Controls.Add(this.coatsNeededTextBox);
            this.Controls.Add(this.sqFtLabel);
            this.Controls.Add(this.sqFtTextBox);
            this.Name = "Prog1";
            this.Text = "Program 1";
            this.Load += new System.EventHandler(this.Prog1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqFtTextBox;
        private System.Windows.Forms.Label sqFtLabel;
        private System.Windows.Forms.TextBox coatsNeededTextBox;
        private System.Windows.Forms.Label coatsNeededLabel;
        private System.Windows.Forms.TextBox paintPriceTextBox;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label totalSqFtOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label paintGallonLabel;
        private System.Windows.Forms.Label paintGallonsOutput;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label laborOutput;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label paintCostOutput;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label laborCostOutput;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label dir1Label;
        private System.Windows.Forms.Label dir2Label;
    }
}

