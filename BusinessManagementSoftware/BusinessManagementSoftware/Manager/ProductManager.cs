using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  BusinessManagementSoftware.Model;
using BusinessManagementSoftware.Repository;

namespace BusinessManagementSoftware.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository= new ProductRepository(); 

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public List<Product> Display()
        {
            return _productRepository.Display();
        }
    }
}
