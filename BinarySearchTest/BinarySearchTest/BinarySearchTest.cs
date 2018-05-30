using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTest
{
    public partial class BinarySeachTest : Form
    {
        private Label promptLabel;

        private TextBox inputTextBox;

        private Label resultLabel;
        private Label displayLabel;
        private Label outputLabel;

        private Button findButon;

        int[] a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28 };

        private void findButton_Click(object sender, EventArgs e)
        {
            int searchKey = Int32.Parse(inputTextBox.Text);

            outputLabel.Text = "Portions of array searched\n";

            int element = BinarySearch(a, searchKey);

            if (element != -1)
                displayLabel.Text = "Found value in element " + element;
            else
                displayLabel.Text = "Value not found";
        }

        public int BinarySearch(int[] a, int key)
        {
            int low = 0;
            int high = a.Length - 1;
            int middle;

            while (low <= high)
            {
                middle = (low + high) / 2;

                BuildOutput(a, low, middle, high);

                if (key == a[middle])
                    return middle;
                else if (key < a[middle])
                    high = middle - 1;
                else
                    low = middle + 1;
            }
            return -1;
        }

        public void BuildOutput(int[] a, int low, int middle, int high)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (i < low || i > high)
                    outputLabel.Text += "     ";
                else if (i == middle)
                    outputLabel.Text += a[i].ToString("00") + "* ";
                else
                    outputLabel.Text += a[i].ToString("00") + "  ";
            }

            outputLabel.Text += "\n";
        }

        public BinarySeachTest()
        {
            InitializeComponent();
        }
    }
}
