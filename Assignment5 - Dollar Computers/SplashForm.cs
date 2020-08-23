using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5___Dollar_Computers
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
