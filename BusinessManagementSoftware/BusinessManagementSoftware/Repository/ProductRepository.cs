using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessManagementSoftware.Model;

namespace BusinessManagementSoftware.Repository
{
    public class ProductRepository
    {
        private SqlConnection sqlConnection = null;
        public bool AddProduct(Product product)
        {
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            string commandString = @"INSERT INTO Products(CategoryId,Code,Name,ReorderLevel,Description) VALUES("+product.CategoryId+",'"+product.Code+"','"+product.Name+"',"+product.ReorderLavel+",'"+product.Description+"')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isAdded = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (isAdded>0)
            {
                return true;
            }
            else
            {
                return false;
            }                      
        }

        public List<Product> Display()
        {
            List<Product> products=new List<Product>();

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            string commandString = @"SELECT * FROM Products";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Id =Convert.ToInt32(sqlDataReader["Id"]);
                product.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReorderLavel = Convert.ToInt32 (sqlDataReader["ReorderLevel"]);
                product.Description = sqlDataReader["Description"].ToString();

                products.Add(product);
            }
            
            sqlConnection.Close();
            return products;
        } 
    }
}
