using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForWithMessageBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int number = 2; number <=100; number +=2)
            {
                sum += number;
            }

            MessageBox.Show("The sum is " + sum,
                "Sum evem Integers from 2 to 100",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Information);

            
        }
    }
}
