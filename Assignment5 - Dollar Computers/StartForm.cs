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
    public partial class StartForm : Form
    {
        /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 20, 2020
      Program description: Character Builder
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
