using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSoftware.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ReorderLavel { get; set; }
        public string Description { get; set; }

        public Product()
        {
           
        }

        public Product(int categoryId,string code,string name,int recordLavel,string description)
        {
            this.CategoryId = categoryId;
            this.Code = code;
            this.Name = name;
            this.ReorderLavel = recordLavel;
            this.Description = description;
        }
    }
}
