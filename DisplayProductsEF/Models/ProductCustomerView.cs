using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayProductsEF.Models
{
    public class ProductCustomerView
    {
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public string ProductColor { get; set; }
        public decimal ProductListPrice { get; set; }
    }
}