using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace RefOutTest
{
    public class RefOutTest : System.Windows.Forms.Form
    {
        private Button showOutputButton;
        private Label outputLabel;

        [STAThread]
        static void Main()
        {
            Application.Run(new RefOutTest());
        }

        void SquareRef(ref int x)
        {
            x = x * x;
        }

        void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        void Square(int x)
        {
            x = x * x;
        }

        private void showOutputButton_Click(object sender, System.EventArgs e)
        {
            int y = 5;
            int z;

            outputLabel.Text = "Original value of y: " + y + "\n";
            outputLabel.Text = "Original value of z: uninitialized\n\n";

            SquareRef(ref y);
            SquareOut(out z);

            outputLabel.Text += "Value of y after SquareRef: " + y + "\n";
            outputLabel.Text += "Value of z after SquareOut: " + z + "\n\n";

            Square(y);
            Square(z);

            outputLabel.Text += "Value of y after Square: " + y + "\n";
            outputLabel.Text += "Value of z after Square: " + z + "\n\n";
        }

    }
}
