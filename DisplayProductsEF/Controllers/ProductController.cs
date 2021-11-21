using DisplayProductsBL;
using DisplayProductsDTO;
using DisplayProductsEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayProductsEF.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        DPBL blObj;
        public ProductController()
        {
            blObj = new DPBL();
        }
        // GET: Product
        //Action Method
        public ActionResult ViewAllProducts()
        {
            List<ProductDTO> lstProducts = blObj.GetAllProducts();
            List<ProductCustomerView> lstFinalOutcome = new List<ProductCustomerView>();
            foreach (var product in lstProducts)
            {
                lstFinalOutcome.Add(new ProductCustomerView()
                {
                    ProductName = product.ProductName,
                    ProductNumber = product.ProductNumber,
                    ProductColor = product.ProductColor,
                    ProductListPrice = product.ProductListPrice
                });
            }
            return View(lstFinalOutcome);
        }
    }
}