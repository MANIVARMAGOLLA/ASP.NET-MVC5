using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayProductsDTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public string ProductColor { get; set; }
        public decimal ProductListPrice { get; set; }
        public int ProductDaysToManufacture { get; set; }
    }
}
