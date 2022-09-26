using System.Collections.Generic;
using DALfile;
using bal_file;

namespace helper
{
    public class Class1
    {
        public List<BL_products> Get_products()
        {
            DAL_product pro = new DAL_product();
            List<BL_products> productsList = new List<BL_products>();
            productsList = pro.ShowAllproducts();
            return productsList;
        }
    }
}