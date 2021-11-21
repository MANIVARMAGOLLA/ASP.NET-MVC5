using DisplayProductsDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayProductsDAL
{
    public class DPDAL
    {
        AdventureWorks2012Entities1 cntxtObj;

        public DPDAL()
        {
            cntxtObj = new AdventureWorks2012Entities1();
        }

        public List<ProductDTO> FetchAllProducts()
        {
            try
            {
                List<Product> lstProductsFromDB = cntxtObj.Products.Where(x => x.ListPrice > 0).ToList();
                List<ProductDTO> lstFinalProducts = new List<ProductDTO>();
                foreach (Product product in lstProductsFromDB)
                {
                    lstFinalProducts.Add(new ProductDTO()
                    {
                        ProductID = product.ProductID,
                        ProductName = product.Name,
                        ProductColor = product.Color,
                        ProductNumber = product.ProductNumber,
                        ProductDaysToManufacture = product.DaysToManufacture,
                        ProductListPrice = product.ListPrice

                    });
                }
                return lstFinalProducts;




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
