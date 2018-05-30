using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace RandomInt
{
    public class RandomInt : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button showOutputButton;
        private System.Windows.Forms.Label outputLabel;

        [STAThread]
        public static void Main(string[] args)
        {
            Application.Run(new RandomInt());
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            Random randomInteger = new Random();
            outputLabel.Text = "";

            for(int counter = 1; counter <= 20; counter++)
            {
                int nextValue = randomInteger.Next(1, 7);

                outputLabel.Text = nextValue + "    ";

                if(counter % 5 == 0)
                {
                    outputLabel.Text += "\n";
                }
            }
        }
    }
}
