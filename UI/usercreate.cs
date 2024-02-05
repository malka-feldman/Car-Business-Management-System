using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPPROJECT1;
using BLL;

namespace UI
{
    public partial class usercreate : Form
    {
        public usercreate()
        {
            InitializeComponent();
        }

        //this is the method to create
        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product(int.Parse(ProdNumTextBox.Text), ProdNameTextBox.Text, double.Parse(CPUTextBox.Text), int.Parse(AmountTextBox.Text));
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Create(prod);
                MessageBox.Show("You created a new Product! " + prod.ToString());
            }
            catch (ProdAlreadyExistsException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usercreate_Load(object sender, EventArgs e)
        {

        }
    }
}
