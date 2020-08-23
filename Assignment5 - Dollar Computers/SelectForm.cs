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
    public partial class SelectForm : Form
    {
        /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 20, 2020
      Program description: Dollar Computers
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }
        private void ComputerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.product.productID = Convert.ToInt16(ComputerdataGridView.SelectedRows[0].Cells[0].Value);
            Program.product.condition = ComputerdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.product.cost = Convert.ToDecimal(ComputerdataGridView.SelectedRows[0].Cells[1].Value);
            Program.product.platform = ComputerdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.product.OS = ComputerdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.product.manufacturer = ComputerdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.product.model = ComputerdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.product.RAM_size = ComputerdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.product.screensize = ComputerdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.product.HDD_size = ComputerdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.product.CPU_brand = ComputerdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.product.CPU_number = ComputerdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.product.GPU_Type = ComputerdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.product.CPU_type = ComputerdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.product.CPU_speed = ComputerdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.product.webcam = ComputerdataGridView.SelectedRows[0].Cells[30].Value.ToString();

            SelectionTextBox.Text = $" {Program.product.manufacturer} {Program.product.model} Priced at: $ {Program.product.cost} ";
        }

        private void SelectCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;

            productInfoForm.Show();
            
        }

        
    }
}
