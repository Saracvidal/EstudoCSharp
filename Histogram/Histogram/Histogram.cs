using System;
using System.Windows.Forms;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int[] n = {19, 3, 15, 7, 11, 9, 13, 5, 17, 1};
            string output = "";

            output += "Element\tvalue\tHistogram\n";

            for(int i = 0; i < n.Length; i++)
            {
                output += "\n" + i + "\t" + n[i] + "\t";

                for (int j = 0; j < n[i]; j++)
                    output += "*";
            }

            MessageBox.Show(output, "Histogram Printing a Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
