using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearSearch
{
    public partial class LinearSearch : Form
    {
        private Button searchButton;
        private TextBox inputTextBox;
        private Label outputLabel;

        public LinearSearch()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LinearSearch());
        }

        int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 };

        public void searchButton_Click(object sender, EventArgs e)
        {
            int searchKey = Int32.Parse(inputTextBox.Text);

            int elementIndex = LinearSearcher(a, searchKey);

            if (elementIndex != -1)
                outputLabel.Text = "Found value in element " + elementIndex;
            else
                outputLabel.Text = "Value not found";
        }

        public int LinearSearcher(int[] a, int searchKey)
        {
            for (int n = 0; n < a.Length; n++)
            {
                if (a[n] == searchKey)
                    return n;
            }

            return -1;
        }

        
    }
}
