using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SquareInt
{
    public class SquareInt : System.Windows.Forms.Form
    {
        private Button calculateButton;
        private Label outputLabel;

        [STAThread]
        static void Main()
        {
            Application.Run(new SquareInt());
        }

        int Square(int y)
        {
            return y * y;
        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            outputLabel.Text = "";

            for(int counter = 1; counter <= 10; counter++)
            {
                int result = Square(counter);

                outputLabel.Text += "The square of" + counter + " is " + result + "\n";
            }
        }
    }
}
