using System;
using System.Windows.Forms;

namespace InitArray
{
    class InitArray
    {
        static void Main(string[] args)
        {
            string output = "";

            int[] x = new int[10];

            int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            const int ARRAY_SIZE = 10;
            int[] z = new int[ARRAY_SIZE];

            for(int i = 0; i < z.Length; i++)
            {
                z[i] = 2 + 2 * i;
            }

            output += "Subscript\tArray x\tArray y\tArray z\n";

            for(int i = 0; i < ARRAY_SIZE; i++)
            {
                output += i + "\t\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n";
            }

            MessageBox.Show(output, "Initializing an array of int values", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
