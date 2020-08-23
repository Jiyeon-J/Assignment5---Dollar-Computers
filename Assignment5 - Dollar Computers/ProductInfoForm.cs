using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5___Dollar_Computers
{
    public partial class ProductInfoForm : Form
    {
        /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 23, 2020
      Program description: Dollar Computers
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */

        public SelectForm previousForm;
        public ProductInfoForm()
        {
            InitializeComponent();
        }

       private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.product.productID.ToString();
            CostTextBox.Text = Program.product.cost.ToString();
            ConditionTextBox.Text = Program.product.condition;
            PlatformTextBox.Text = Program.product.platform;
            OSTextBox.Text = Program.product.OS;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            LCDSizeTextBox.Text = Program.product.screensize;
            HDDTextBox.Text = Program.product.HDD_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUnumberTextBox.Text = Program.product.CPU_number;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            CPUspeedTextBox.Text = Program.product.CPU_speed;
            WebCamTextBox.Text = Program.product.webcam;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the open file dialog
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            //open the file dialog
            var OpenFileDialogResult = OpenFileDialog.ShowDialog();

            //Display the File Open dialog box.

            if (OpenFileDialogResult != DialogResult.Cancel)
            { 
                // Create a new stream reader
                StreamReader streamReader = new StreamReader("Product.txt");
                
                while (!streamReader.EndOfStream)
                {
                    Program.product.productID = Convert.ToInt16(streamReader.ReadLine());
                    Program.product.cost = Convert.ToDecimal(streamReader.ReadLine());
                    Program.product.condition = streamReader.ReadLine();
                    Program.product.platform = streamReader.ReadLine();
                    Program.product.OS = streamReader.ReadLine();
                    Program.product.manufacturer = streamReader.ReadLine();
                    Program.product.model = streamReader.ReadLine();
                    Program.product.RAM_size = streamReader.ReadLine();
                    Program.product.screensize = streamReader.ReadLine();
                    Program.product.HDD_size = streamReader.ReadLine();
                    Program.product.CPU_brand = streamReader.ReadLine();
                    Program.product.CPU_number = streamReader.ReadLine();
                    Program.product.GPU_Type = streamReader.ReadLine();
                    Program.product.CPU_type = streamReader.ReadLine();
                    Program.product.CPU_speed = streamReader.ReadLine();
                    Program.product.webcam = streamReader.ReadLine();
                }

                streamReader.Close();
            }

            ProductIDTextBox.Text = Program.product.productID.ToString();
            CostTextBox.Text = Program.product.cost.ToString();
            ConditionTextBox.Text = Program.product.condition;
            PlatformTextBox.Text = Program.product.platform;
            OSTextBox.Text = Program.product.OS;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            LCDSizeTextBox.Text = Program.product.screensize;
            HDDTextBox.Text = Program.product.HDD_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUnumberTextBox.Text = Program.product.CPU_number;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            CPUspeedTextBox.Text = Program.product.CPU_speed;
            WebCamTextBox.Text = Program.product.webcam;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            var SaveFileDialogResult = SaveFileDialog.ShowDialog();

            if (SaveFileDialogResult != DialogResult.Cancel)
            {
                StreamWriter streamWriter = new StreamWriter(SaveFileDialog.FileName);

                streamWriter.WriteLine(Program.product.productID);
                streamWriter.WriteLine(Program.product.cost);
                streamWriter.WriteLine(Program.product.condition);
                streamWriter.WriteLine(Program.product.platform);
                streamWriter.WriteLine(Program.product.OS);
                streamWriter.WriteLine(Program.product.manufacturer);
                streamWriter.WriteLine(Program.product.model);
                streamWriter.WriteLine(Program.product.RAM_size);
                streamWriter.WriteLine(Program.product.screensize);
                streamWriter.WriteLine(Program.product.HDD_size);
                streamWriter.WriteLine(Program.product.CPU_brand);
                streamWriter.WriteLine(Program.product.CPU_number);
                streamWriter.WriteLine(Program.product.GPU_Type);
                streamWriter.WriteLine(Program.product.CPU_type);
                streamWriter.WriteLine(Program.product.CPU_speed);
                streamWriter.WriteLine(Program.product.webcam);

                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();

            this.Close();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.selectForm.Show();
            this.Hide();
        }
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
