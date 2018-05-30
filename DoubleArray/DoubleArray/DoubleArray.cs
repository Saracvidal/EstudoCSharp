using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleArray
{
    public partial class DoubleArray : Form
    {
        private Button showOutputButton;
        private Label outputLabel;

        int[][] grades;
        int students, exams;

        public DoubleArray()
        {
            InitializeComponent();
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            grades = new int[3][];
            grades[0] = new int[] { 77, 68, 86, 73};
            grades[1] = new int[] { 96, 87, 89, 81 };
            grades[2] = new int[] { 70, 90, 86, 81 };

            students = grades.Length;
            exams = grades[0].Length;

            outputLabel.Text = "                ";

            for(int i = 0; i < exams; i++)
                outputLabel.Text += "[" + i + "]   ";

            for (int i = 0; i < students; i++)
            {
                outputLabel.Text += "\ngrades[" + i + "]   ";

                for (int j = 0; j < exams; j++)
                    outputLabel.Text += grades[i][j] + "    ";
            }

            outputLabel.Text += "\n\nLowest grade: " + Minimum() + "\nHighest grade: " + Maximum() + "\n";

            for (int i = 0; i < students; i++)
                outputLabel.Text += "\nAverage for student " + i + " is " + Average(grades[i]) ;

        }

        public int Minimum()
        {
            int lowGrade = 100;

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < exams; j++)
                    if (grades[i][j] < lowGrade)
                        lowGrade = grades[i][j];
            }

            return lowGrade;
        }

        public int Maximum()
        {
            int highGrade = 0;

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < exams; j++)
                    if (grades[i][j] > highGrade)
                        highGrade = grades[i][j];
            }

            return highGrade;

        }

        public int Average(int[] grades)
        {
            int total = 0;

            for (int i = 0; i < exams; i++)
                total += grades[i];

            return total / grades.Length;
        }

    }
}
