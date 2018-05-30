using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Scoping
{
    public class Scopingg : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button showOutputButton;

        public int x = 1;

        public void MethodA()
        {
            int x = 25;
            outputLabel.Text = outputLabel.Text + "\n\nlocal x in MethodA is " + x + " after entering MethodA";

            ++x;

            outputLabel.Text = outputLabel.Text + "\n\nlocal x in MethodA is " + x + " before exiting MethodA";
        }

        public void MethodB()
        {
            outputLabel.Text = outputLabel.Text + "\n\ninstance variable x is " + x + " on entering MethodB";

            x *= 10;

            outputLabel.Text = outputLabel.Text + "\n\ninstance variable x is " + x + " on exiting MethodB";
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            int x = 5;
            outputLabel.Text = "Local x in method showOutputButton_Click is " + x;

            MethodA();
            MethodB();
            MethodA();
            MethodB();

            outputLabel.Text = outputLabel.Text + "\n\n" + "local x in method showOutputButton_Click is " + x;
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new Scopingg());
        }
    }
}
