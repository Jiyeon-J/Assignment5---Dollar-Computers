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
    public partial class OrderForm : Form
    {
        /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 23, 2020
      Program description: Dollar Computers
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */
        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.product.condition;
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;
            LCDSizeTextBox.Text = Program.product.screensize;
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            CPUnumberTextBox.Text = Program.product.CPU_number;
            CPUspeedTextBox.Text = Program.product.CPU_speed;
            HDDTextBox.Text = Program.product.HDD_size;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WebCamTextBox.Text = Program.product.webcam;
            OSTextBox.Text = Program.product.OS;


            PriceTextBox.Text = $"$ { Program.product.cost.ToString()}";
            SalesTaxTextBox.Text = $"$ {((Program.product.cost) * 0.13m).ToString()}";
            TotalTextBox.Text = $"$ {(Program.product.cost + ((Program.product.cost) * 0.13m)).ToString()}";
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Your selection is printing now.");
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Thank you for your order.\nYour order will be delivered in 7-10 business days.","Information", MessageBoxButtons.OK);
           if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.Show();
        }
    }
}
