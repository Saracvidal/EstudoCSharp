using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASimpleProgram
{
    public partial class ASimpleProgram : Form
    {
        public ASimpleProgram()
        {
            InitializeComponent();
        }

        private void ASimpleProgram_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "These are beautifull birds... ";
        }
    }
}
