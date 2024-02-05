using BLL;
using DAL;
using Entities;
using OOPPROJECT1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderForm : BaseForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           // comboBox1.Items.AddRange(customers.ToArray());
        }

        protected override void New_Method()
        {
            ShowButtonProd.Visible = false;
            CustomerIDLabel.Visible = true;
            OrderIdLabel.Location = new System.Drawing.Point(40, 180);
            OrderIdTextBox.Location = new System.Drawing.Point(130, 180);
            CustomerIDTextBox.Visible = true;
            OrderIdTextBox.Visible = true;  
            OrderIdLabel.Visible = true;    
            ProductNumberLabel.Visible = true;
            ProductNumberTextBox.Visible = true;   
            OrderQuantityLabel.Visible = true;
            OrderQuantityTextBox.Visible = true;
            label1.Visible = false;
            ShowLabel.Visible = false;
            createButton.Visible = true;
            DeleteButton.Visible = false;
            ShowButtonC.Visible = false;
            ShowByCustomerButton.Visible = false;
            ShowByProductButton.Visible = false;
            ShowAllButton.Visible = false;
            Update.Visible = false;
            ShowByCustomerButton.Visible = false;
            Find.Visible = false;
            createButton.Location = new System.Drawing.Point(75, 220);

        }

        protected override void Delete_Method()
        {
            ShowButtonProd.Visible = false;
            OrderIdLabel.Visible = true;
            OrderIdTextBox.Visible = true;
            OrderIdLabel.Location = new System.Drawing.Point(75, 80);
            OrderIdTextBox.Location = new System.Drawing.Point(75, 100);
            CustomerIDLabel.Visible = false;
            CustomerIDTextBox.Visible = false;
            ProductNumberLabel.Visible = false;
            ProductNumberTextBox.Visible = false;
            OrderQuantityLabel.Visible = false;
            OrderQuantityTextBox.Visible = false;
            createButton.Visible = false;
            ShowButtonC.Visible=false;
            ShowByCustomerButton.Visible = false;
            ShowByCustomerButton.Visible = false;
            ShowByProductButton.Visible = false;
            label1.Visible = false;
            ShowAllButton.Visible = false;
            Update.Visible = false;
            Find.Visible = false;
            ShowLabel.Visible = false;
            DeleteButton.Visible = true;
            DeleteButton.Location = new System.Drawing.Point(70, 125);
        }

        protected override void Find_Method()
        {
            ShowButtonProd.Visible = false;
            OrderIdLabel.Visible = true;
            OrderIdTextBox.Visible = true;
            OrderIdLabel.Location = new System.Drawing.Point(75, 80);
            OrderIdTextBox.Location = new System.Drawing.Point(75, 100);
            CustomerIDLabel.Visible = false;
            CustomerIDTextBox.Visible = false;
            ProductNumberLabel.Visible=false;
            ProductNumberTextBox.Visible=false; 
            OrderQuantityLabel.Visible = false;
            OrderQuantityTextBox.Visible=false;
            createButton.Visible = false;
            ShowButtonC.Visible = false;
            DeleteButton.Visible = false;
            ShowByCustomerButton.Visible = false;
            ShowByProductButton.Visible = false;
            label1.Visible = false;
            ShowAllButton.Visible = false;  
            ShowLabel.Visible = false;
            Update.Visible = false;
            Find.Visible = true;
            Find.Location = new System.Drawing.Point(70, 125);
        }

        protected override void Update_Method()
        {
            ShowButtonProd.Visible = false;
            OrderIdLabel.Visible = true;
            OrderIdTextBox.Visible = true;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            ProductNumberLabel.Visible = true;
            label1.Visible = false;
            ProductNumberTextBox.Visible = true;
            OrderQuantityLabel.Visible = true;
            OrderQuantityTextBox.Visible = true;
            createButton.Visible = false;
            ShowButtonC.Visible = false;
            DeleteButton.Visible = false;
            ShowByProductButton.Visible = false;
            ShowAllButton.Visible = false;
            ShowByCustomerButton.Visible = false;
            Find.Visible = false;
            Update.Visible = true;
            ShowLabel.Visible = false;
            OrderIdTextBox.Location = new System.Drawing.Point(130, 50);
            OrderIdLabel.Location = new System.Drawing.Point(50, 50);
            Update.Location = new System.Drawing.Point(70, 215);
        }

        protected override void Show_Method()
        {
            label1.Visible = false;
            ShowButtonProd.Visible = false;
            OrderIdLabel.Visible = false;
            OrderIdTextBox.Visible = false;
            ShowByCustomerButton.Visible = true;
            ShowByProductButton.Visible = true;
            ShowAllButton.Visible = true;
            OrderIdLabel.Location = new System.Drawing.Point(75, 80);
            OrderIdTextBox.Location = new System.Drawing.Point(75, 100);
            CustomerIDLabel.Visible = false;
            CustomerIDTextBox.Visible = false;
            ProductNumberLabel.Visible = false;
            ProductNumberTextBox.Visible = false;
            OrderQuantityLabel.Visible = false;
            OrderQuantityTextBox.Visible = false;
            createButton.Visible = false;
            Find.Visible = false;
            DeleteButton.Visible = false;
            ShowButtonC.Visible=false;
            Update.Visible = false;
            ShowByCustomerButton.Visible = true;
            ShowLabel.Visible = true;
            ShowByCustomerButton.Location = new System.Drawing.Point(100, 80);
            ShowByProductButton.Location = new System.Drawing.Point(100, 120);
            ShowAllButton.Location = new System.Drawing.Point(100, 160);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Order order = new Order(int.Parse(ProductNumberTextBox.Text), int.Parse(CustomerIDTextBox.Text), int.Parse(OrderIdTextBox.Text), int.Parse(OrderQuantityTextBox.Text));
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                orderBLL.Create(order/*, ProductDAL.products*/);
                ClearTextBoxes();
                MessageBox.Show("The order has been created. ");
            }
            catch(OrderAlreadyExistsException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
            catch(ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
            catch (ProductNotInStock exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void ShowByCustomerButton_Click(object sender, EventArgs e)
        {
            ShowByCustomerButton.Visible = false;
            label1.Visible = false;
            ShowByProductButton.Visible = false;
            ShowAllButton.Visible = false;
            CustomerIDLabel.Visible = true;
            CustomerIDTextBox.Visible = true;
            ShowButtonC.Visible = true;
            ShowButtonC.Location = new System.Drawing.Point(75, 120);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                label1.Text = orderBLL.readByCustomer(int.Parse(CustomerIDTextBox.Text));
            }
            catch (OrderNoExist exc)
            {
                label1.Visible = false;
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            ShowByCustomerButton.Visible = false;
            ShowByProductButton.Visible = false;
            label1.Visible = true;
            OrderBLL orderBLL = new OrderBLL();
            if(orderBLL.readAll() == null)
            {
                label1.Text = "There are no orders to show";
            }
            else
            {
                try
                {
                    label1.Text = orderBLL.readAll();
                }
                catch (OrderNoExist exc)
                {
                    label1.Visible = false;
                    MessageBox.Show("Error! " + exc.Message);
                }
            }
        }

        private void ShowByProductButton_Click(object sender, EventArgs e)
        {
            ShowByCustomerButton.Visible = false;
            ShowByProductButton.Visible = false;
            ShowAllButton.Visible = false;
            ProductNumberLabel.Visible = true;
            ProductNumberTextBox.Visible = true;
            ShowButtonProd.Visible = true;
            ShowButtonProd.Location = new System.Drawing.Point(75, 140);
        }

        private void ShowButtonProd_Click(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                label1.Visible = true;
                label1.Text = orderBLL.ReadByProduct(int.Parse(ProductNumberTextBox.Text));
            }
            catch (OrderNoExist exc)
            {
                label1.Visible = false;
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string str = "";
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                label1.Visible = true;
                orderBLL.Retrieve(int.Parse(OrderIdTextBox.Text));
                str = orderBLL.Retrieve(int.Parse(OrderIdTextBox.Text)).ToString();
                label1.Text = str;
                ClearTextBoxes();

            }
            catch (OrderNoExist exc)
            {
                label1.Visible = false;
                MessageBox.Show("Error! " + exc.Message);
                ClearTextBoxes();

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                orderBLL.Delete(int.Parse(OrderIdTextBox.Text));
                ClearTextBoxes();
                MessageBox.Show("The order has been deleted.");
            }
            catch (OrderNoExist exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Order order = new Order(int.Parse(ProductNumberTextBox.Text), int.Parse(CustomerIDTextBox.Text), int.Parse(OrderIdTextBox.Text), int.Parse(OrderQuantityTextBox.Text));
            OrderBLL orderBLL = new OrderBLL();
            try
            {
                orderBLL.Update(order);
                ClearTextBoxes();
                MessageBox.Show("The order has been updated. ");
            }
            catch (OrderNoExist exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void ClearTextBoxes()
        {
            ProductNumberTextBox.Text = string.Empty;
            CustomerIDTextBox.Text = string.Empty;  
            OrderIdTextBox.Text = string.Empty; 
            OrderQuantityTextBox.Text = string.Empty;
        }
    }
}
