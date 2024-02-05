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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI
{
    public partial class CustomerForm : BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        protected override void New_Method()
        {
            label1.Visible = false;
            CustomerNameLabel.Visible = true;
            CustomerNameTextBox.Visible = true;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            ShowLabel.Visible = false;
            createButton.Visible = true;
            DeleteButton.Visible = false;
            Update.Visible = false;
            ShowButton.Visible = false;
            Find.Visible = false;
            createButton.Location = new System.Drawing.Point(75, 200);

        }

        protected override void Delete_Method()
        {
            label1.Visible = false;
            CustomerNameLabel.Visible = true;
            CustomerNameTextBox.Visible = true;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            createButton.Visible = false;
            ShowButton.Visible = false;
            Update.Visible = false;
            Find.Visible = false;
            ShowLabel.Visible = false;
            DeleteButton.Visible = true;
            DeleteButton.Location = new System.Drawing.Point(75, 200);
        }

        protected override void Find_Method()
        {
            label1.Visible = false;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            createButton.Visible = false;
            DeleteButton.Visible = false;
            ShowButton.Visible=false;
            ShowLabel.Visible = false;
            Update.Visible = false;
            Find.Visible = true;
            Find.Location = new System.Drawing.Point(75, 200);
        }

        protected override void Update_Method()
        {
            label1.Visible = false;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            CustomerNameLabel.Visible = true;
            CustomerNameTextBox.Visible = true;
            createButton.Visible = false;
            DeleteButton.Visible = false;
            ShowButton.Visible = false;
            Find.Visible= false;    
            Update.Visible = true;
            ShowLabel.Visible = false;
            Update.Location = new System.Drawing.Point(75, 200);
        }

        protected override void Show_Method()
        {
            label1.Visible = false;
            CustomerIDLabel.Visible = false;
            CustomerIDTextBox.Visible = false;
            CustomerNameTextBox.Visible = false;
            CustomerNameLabel.Visible = false;
            createButton.Visible = false;
            Find.Visible = false;
            DeleteButton.Visible = false;
            Update.Visible= false;
            ShowButton.Visible = true;
            ShowLabel.Visible = true;
            ShowButton.Location = new System.Drawing.Point(65, 100);

        }

        private void Find_Click(object sender, EventArgs e)
        {
            CustomerBLL custoBLL = new CustomerBLL();
            try
            {
                Customer cust = custoBLL.Retrieve(int.Parse(CustomerIDTextBox.Text));
                ClearText();
                MessageBox.Show("You successfully retrieved the customer: " + cust.ToString());
            }
            catch (ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Customer custo = new Customer((CustomerNameTextBox.Text), (int.Parse(CustomerIDTextBox.Text)));
            CustomerBLL custBLL = new CustomerBLL();
            try
            {
                custBLL.Create(custo);
                ClearText();

                MessageBox.Show("Customer has been created. " + custo.ToString());
            }
            catch (CustomerAlreadyExistsException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Customer custo = new Customer((CustomerNameTextBox.Text), (int.Parse(CustomerIDTextBox.Text)));
            CustomerBLL custBLL = new CustomerBLL();
            try
            {
                custBLL.Delete(int.Parse(CustomerIDTextBox.Text));
                ClearText();

                MessageBox.Show("Customer has been deleted. " + custo.ToString());
            }
            catch (CustomerNoExists exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Customer custo = new Customer((CustomerNameTextBox.Text), (int.Parse(CustomerIDTextBox.Text)));
            CustomerBLL custBLL = new CustomerBLL();
            try
            {
                custBLL.Update(custo);
                ClearText();
                MessageBox.Show("Customer has been updated" + custo.ToString());
            }
            catch (CustomerNoExists exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            CustomerBLL custBLL = new CustomerBLL();
            label1.Text = custBLL.printBLLList();
        }

        private void ClearText()
        {
            CustomerNameTextBox.Text = String.Empty;
            CustomerIDTextBox.Text = String.Empty;
        }

    }
}
