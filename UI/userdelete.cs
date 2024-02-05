using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using OOPPROJECT1;

namespace UI
{
    public partial class userdelete : Form
    {
        public userdelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Delete(int.Parse(textBox1.Text));
                MessageBox.Show("You  successfully deleted the product" + prodBLL.ToString());
            }
            catch (ReqProdNumNoExistException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void userdelete_Load(object sender, EventArgs e)
        {

        }
    }
}
