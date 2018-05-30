using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace RollDie
{
    public class RollDie : System.Windows.Forms.Form
    {
        private Button rollButton;

        private Label dieLaabel12;
        private Label dieLaabel11;
        private Label dieLaabel13;
        private Label dieLaabel14;

        private Random randomNumber = new Random();

        protected void rollButton_Click(object sender, EventArgs e)
        {
            DisplayDie(dieLaabel11);
            DisplayDie(dieLaabel12);
            DisplayDie(dieLaabel13);
            DisplayDie(dieLaabel14);
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomNumber.Next(1, 7);

            dieLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + face + ".png");

        }

        static void Main(string[] args)
        {
            Application.Run(new RollDie());
        }
    }
}
