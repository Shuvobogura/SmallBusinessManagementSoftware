using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementSoftware
{
    public partial class BusinessManagementUi : Form
    {
        public BusinessManagementUi()
        {
            InitializeComponent();
        }

        private void loginPictureBox_Click(object sender, EventArgs e)
        {
            LoginUi loginUi=new LoginUi();
            loginUi.Show();
        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {
            ProductUi productUi=new ProductUi();
            
            productUi.Show();
        }

        private void stockPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
