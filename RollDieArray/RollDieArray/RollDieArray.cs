using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Windows.Markup;

namespace RollDieArray
{
    public partial class RollDieArray : Form
    {
        private System.Windows.Forms.Button rollButton;

        private System.Windows.Forms.RichTextBox displayTextBox;

        private System.Windows.Forms.Label dieLabel1;
        private System.Windows.Forms.Label dieLabel2;
        private System.Windows.Forms.Label dieLabel3;
        private System.Windows.Forms.Label dieLabel4;
        private System.Windows.Forms.Label dieLabel5;
        private System.Windows.Forms.Label dieLabel6;
        private System.Windows.Forms.Label dieLabel7;
        private System.Windows.Forms.Label dieLabel8;
        private System.Windows.Forms.Label dieLabel9;
        private System.Windows.Forms.Label dieLabel10;
        private System.Windows.Forms.Label dieLabel11;
        private System.Windows.Forms.Label dieLabel12;

        private System.ComponentModel.Container component = null;

        Random randomNumber = new Random();
        int[] frequency = new int[7];

        public RollDieArray()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new RollDieArray());
        }

        private void rollButton_Click(object sender, System.EventArgs e)
        {
            DisplayDie(dieLabel1);
            DisplayDie(dieLabel2);
            DisplayDie(dieLabel3);
            DisplayDie(dieLabel4);
            DisplayDie(dieLabel5);
            DisplayDie(dieLabel6);
            DisplayDie(dieLabel7);
            DisplayDie(dieLabel8);
            DisplayDie(dieLabel9);
            DisplayDie(dieLabel10);
            DisplayDie(dieLabel11);
            DisplayDie(dieLabel12);

            double total = 0;

            for (int i = 0; i < 7; i++)
            {
                total += frequency[i];
            }

            displayTextBox.Text = "Face\tFrequency\tPercent\n";

            for (int x = 1; x < frequency.Length; x++)
            {
                displayTextBox.Text += x + "\t" + frequency[x] + "\t\t" + String.Format("{0:N}", frequency[x] / total * 100) + "%\n";
            }
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomNumber.Next(1, 7);

            dieLabel.Image = new Bitmap(Directory.GetCurrentDirectory() + "\\die" + face + ".gif");

            frequency[face]++;
        }
    }
}