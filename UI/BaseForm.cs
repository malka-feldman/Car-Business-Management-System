using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {

        }

        protected virtual void New_Method()
        {

        }
        protected virtual void Delete_Method()
        {

        }

        protected virtual void Find_Method()
        {

        }

        protected virtual void Show_Method()
        {

        }

        protected virtual void Update_Method()
        {

        }

        protected virtual void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New_Method();
        }

        protected void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            Delete_Method();
        }

        protected void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Find_Method();
        }

        protected void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Show_Method();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Update_Method();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
