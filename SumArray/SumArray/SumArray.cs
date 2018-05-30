using System;
using System.Windows.Forms;

namespace SumArray
{
    class SumArray
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total = 0;

            for (int i = 0; i < a.Length; i++)
                total += a[i];

            MessageBox.Show("Total of array elements: " + total, "Sum the elements of an array", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
