using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  BusinessManagementSoftware.Model;
using  BusinessManagementSoftware.Manager;

namespace BusinessManagementSoftware
{
    public partial class ProductUi : Form
    {
        ProductManager _productManager=new  ProductManager();
        private Product _product;
        public ProductUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _product = new Product(1,codeTextBox.Text,nameTextBox.Text,Convert.ToInt32(recordLevelTextBox.Text),descriptionTextBox.Text);

            if (_productManager.AddProduct(_product))
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            showProductDataGridView.DataSource = _productManager.Display();
        }

        private void ProductUi_Load(object sender, EventArgs e)
        {

           showProductDataGridView.DataSource= _productManager.Display();

        }
    }
}
