using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FactorialTest
{
    public class FactorialTest: System.Windows.Forms.Form
    {
        private Button showFactorialButton;
        private Label outputLabel;

        public long Factorial(long number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        

        #region Windows Form Designer generate code

        private void InitializeComponent()
        {
            this.showFactorialButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            //showFactorialButton
            this.showFactorialButton.Location = new System.Drawing.Point(24, 120);
            this.showFactorialButton.Name = "showFactorialButton";
            this.showFactorialButton.Size = new System.Drawing.Size(112, 23);
            this.showFactorialButton.TabIndex = 0;
            this.showFactorialButton.Text = "Factorial Button";
            this.showFactorialButton.Click += new System.EventHandler(this.ShowFactorialButton_Click);

            //outputLabel
            this.outputLabel.Location = new System.Drawing.Point(40, 60);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 80);
            this.outputLabel.TabIndex = 1;

            //FactorialTest
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 205);
            this.Controls.AddRange(
                new System.Windows.Forms.Control[] {
                        this.showFactorialButton,
                        this.outputLabel
                }

            );

            this.Name = "FactorialTest";
            this.Text = "FactorialTest";
            this.ResumeLayout(false);
        }
        #endregion

        [STAThread]
        static void Main(string[] args)
        {
            FactorialTest factorialT = new FactorialTest();
            Application.Run(factorialT);
        }

        private void ShowFactorialButton_Click(object sender, System.EventArgs e)
        {
            outputLabel.Text = "";
            for(long i = 0; i <=10; i++)
            {
                outputLabel.Text += i + "! = " + Factorial(i) + "\n";
            }
        }
    }
}
