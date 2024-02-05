using BLL;
using DAL;
using Entities;
using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace UI
{
    public partial class ProductForm : BaseForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }

        protected override void New_Method()
        {
            label1.Visible = false;     
            ProductNumberLabel.Visible = true;
            ProductNameLabel.Visible = true;
            ProductNumberTextBox.Visible = true;
            ProductNameTextBox.Visible = true;
            CPULabel.Visible = true;
            Amountlabel.Visible = true;
            amountTextBox.Visible = true;   
            CPUTextBox.Visible = true;
            enterButton.Visible = true;
            ShowButton.Visible = false;
            FindButton.Visible = false;
            ShowLabel.Visible = false;
            DeleteButton.Visible = false;
            UpdateButton.Visible = false;
            ShowButton.Visible = false;
            enterButton.Location = new System.Drawing.Point(75, 200);
        }

        protected override void Delete_Method()
        {
            label1.Visible = false;
            ProductNumberLabel.Visible = true;
            ProductNameLabel.Visible = false;
            ProductNumberTextBox.Visible = true;
            ProductNameTextBox.Visible = false;
            CPULabel.Visible = false;
            UpdateButton.Visible = false;
            CPUTextBox.Visible = false;
            ShowButton.Visible = false;
            enterButton.Visible = false;
            FindButton.Visible = false;
            ShowLabel.Visible = false;
            ShowButton.Visible = false;
            Amountlabel.Visible = false;
            amountTextBox.Visible = false;
            DeleteButton.Visible = true;
            DeleteButton.Location = new System.Drawing.Point(75, 120);
        }

        protected override void Show_Method()
        {
            label1.Visible = false;
            ProductNumberLabel.Visible = false;
            ProductNameLabel.Visible = false;
            ProductNumberTextBox.Visible = false;
            ProductNameTextBox.Visible = false;
            CPULabel.Visible = false;
            UpdateButton.Visible = false;
            ShowLabel.Visible = true;
            Amountlabel.Visible = false;
            amountTextBox.Visible = false;
            CPUTextBox.Visible = false;
            enterButton.Visible = false;
            FindButton.Visible = false;
            DeleteButton.Visible = false;
            ShowButton.Visible = true;
            ShowButton.Location = new System.Drawing.Point(65, 100);
        }

        protected override void Find_Method()
        {
            label1.Visible = false;
            ProductNumberTextBox.Visible = false;
            ProductNameTextBox.Visible = false;
            ProductNumberLabel.Visible = false;
            ProductNameLabel.Visible = false;
            CPULabel.Visible = false;
            Amountlabel.Visible = false;
            amountTextBox.Visible = false;
            CPUTextBox.Visible = false;
            enterButton.Visible = false;
            ShowButton.Visible = false;
            DeleteButton.Visible = false;
            ShowLabel.Visible = false;
            UpdateButton.Visible = false;
            ProductNumberLabel.Visible = true;
            ProductNumberTextBox.Visible = true;
            FindButton.Visible = true;
            ShowButton.Visible = false;
            FindButton.Location = new System.Drawing.Point(75, 120);
        }

        protected override void Update_Method()
        {
            label1.Visible = false;
            ProductNumberLabel.Visible = true;
            ProductNameLabel.Visible = true;
            ProductNumberTextBox.Visible = true;
            ProductNameTextBox.Visible = true;
            CPULabel.Visible = true;
            CPUTextBox.Visible = true;
            enterButton.Visible = true;
            FindButton.Visible = false;
            Amountlabel.Visible = true;
            amountTextBox.Visible = true;
            DeleteButton.Visible = false;
            ShowButton.Visible = false;
            ShowLabel.Visible = false;
            enterButton.Visible = false;
            UpdateButton.Visible = true;
            UpdateButton.Location = new System.Drawing.Point(75, 200);
            ShowButton.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product(int.Parse(ProductNumberTextBox.Text), ProductNameTextBox.Text, double.Parse(CPUTextBox.Text), int.Parse(amountTextBox.Text));
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Create(prod);
                ClearText();
                MessageBox.Show("You created a new Product! " + prod.ToString());
            }
            catch (ProdAlreadyExistsException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Delete(int.Parse(ProductNumberTextBox.Text));
                ClearText();
                MessageBox.Show("You  successfully deleted the product!");
            }
            catch (ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            ProductBLL prodBLL = new ProductBLL();
            label1.Text = prodBLL.printBLLList();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                Product prod = prodBLL.Retrieve(int.Parse(ProductNumberTextBox.Text));
                ClearText();
                MessageBox.Show("You successfully retrieved the product: " + prod.ToString());
            }
            catch (ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product(int.Parse(ProductNumberTextBox.Text), ProductNameTextBox.Text, double.Parse(CPUTextBox.Text), int.Parse(amountTextBox.Text));
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Update(prod);
                ClearText();
                MessageBox.Show("Product has been updated. " + prod.ToString());
            }
            catch (ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }
        private void ClearText()
        {
            ProductNumberTextBox.Text = String.Empty;
            ProductNameTextBox.Text = String.Empty;
            CPUTextBox.Text = String.Empty; 
            amountTextBox.Text = String.Empty;  

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CPULabel_Click(object sender, EventArgs e)
        {

        }

    }
}
