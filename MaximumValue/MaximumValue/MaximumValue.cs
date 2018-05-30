using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MaximumValue
{
    public class MaximumValue : System.Windows.Forms.Form
    {
        private Label firstNumberLabel;
        private Label secondNumberLabel;
        private Label thirdNumberLabel;
        private Label maximumLabel;
        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private TextBox thirdNumberTextBox;
        private Button calculateButton;

        private System.ComponentModel.Container components = null;

        public MaximumValue()
        {
            InitializeComponent();
        }

        protected override void Dispose (bool disposing)
        {
            if(disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generate code

        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.thirdNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.thirdNumberLabel = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(29, 138);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(134, 27);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Maximum";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(211, 18);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(120, 22);
            this.firstNumberTextBox.TabIndex = 1;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(211, 57);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(120, 22);
            this.secondNumberTextBox.TabIndex = 2;
            // 
            // thirdNumberTextBox
            // 
            this.thirdNumberTextBox.Location = new System.Drawing.Point(211, 93);
            this.thirdNumberTextBox.Name = "thirdNumberTextBox";
            this.thirdNumberTextBox.Size = new System.Drawing.Size(120, 22);
            this.thirdNumberTextBox.TabIndex = 3;
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.Location = new System.Drawing.Point(10, 18);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(163, 27);
            this.firstNumberLabel.TabIndex = 4;
            this.firstNumberLabel.Text = "First Floating-Point Value:";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.Location = new System.Drawing.Point(10, 55);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(182, 27);
            this.secondNumberLabel.TabIndex = 5;
            this.secondNumberLabel.Text = "Second Floating-Point Value:";
            // 
            // thirdNumberLabel
            // 
            this.thirdNumberLabel.Location = new System.Drawing.Point(10, 92);
            this.thirdNumberLabel.Name = "thirdNumberLabel";
            this.thirdNumberLabel.Size = new System.Drawing.Size(172, 27);
            this.thirdNumberLabel.TabIndex = 6;
            this.thirdNumberLabel.Text = "Third Floating-Point Value:";
            // 
            // maximumLabel
            // 
            this.maximumLabel.Location = new System.Drawing.Point(211, 138);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(120, 93);
            this.maximumLabel.TabIndex = 7;
            // 
            // MaximumValue
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(471, 205);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.thirdNumberLabel);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.thirdNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "MaximumValue";
            this.Text = "MaximumValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new MaximumValue());
        }

        double Maximum(double x, double y, double z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            double number1 = double.Parse(firstNumberTextBox.Text);
            double number2 = double.Parse(secondNumberTextBox.Text);
            double number3 = double.Parse(thirdNumberTextBox.Text);
            double maximum = Maximum(number1, number2, number3);

            maximumLabel.Text = "Maximum is: " + maximum;
        }
    }
}
