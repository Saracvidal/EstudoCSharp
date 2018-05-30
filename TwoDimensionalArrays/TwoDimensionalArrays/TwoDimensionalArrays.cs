using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDimensionalArrays
{
    public partial class TwoDimensionalArrays : Form
    {
        private Button showOutputButton;
        private Label outputLabel;

        public TwoDimensionalArrays()
        {
            InitializeComponent();
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            int[,] array1 = new int[,] { { 1, 2, 3}, { 4, 5, 6}};

            int[][] array2 = new int[3][];
            array2[0] = new int[] { 1, 2 };
            array2[1] = new int[] {3};
            array2[2] = new int[] {4, 5, 6};

            outputLabel.Text = "Values in array1 by row are\n";

            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    outputLabel.Text += array1[i, j] + "  ";
                }
                outputLabel.Text += "\n";
            }

            outputLabel.Text += "\nValues in array2 by row are\n";


            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2[i].Length; j++)
                {
                    outputLabel.Text += array2[i][j] + "  ";
                }
                outputLabel.Text += "\n";
            }

        }
    }
}
