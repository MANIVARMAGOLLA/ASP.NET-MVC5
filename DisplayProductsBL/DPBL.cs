using DisplayProductsDAL;
using DisplayProductsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayProductsBL
{
    public class DPBL
    {
        DPDAL dalobj;
        public DPBL()
        {
            dalobj = new DPDAL();
        }
        
        public List<ProductDTO> GetAllProducts()
        {
            try
            {
                List<ProductDTO> lstFinalProducts = dalobj.FetchAllProducts();
                return lstFinalProducts;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
