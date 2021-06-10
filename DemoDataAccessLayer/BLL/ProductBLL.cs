using DemoDataAccessLayer.DAL;
using DemoDataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.BLL
{
    public class ProductBLL
    {
        public List<Product> GetListProductByCategoryID(int categoryID)
        {
            List<Product> listProduct = new List<Product>();
            DataTable dataTable = ProductDAL.GetProductByCategoryID(categoryID);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listProduct.Add(new Product(Int32.Parse(dataRow["ProductID"].ToString()),dataRow["ProductName"].ToString(),dataRow["QuantityPerUnit"].ToString(),Decimal.Parse(dataRow["UnitPrice"].ToString())));
            }
            return listProduct;
        }
        public DataTable GetDataTableProductByCategoryID(int categoryID)
        {
            return ProductDAL.GetProductByCategoryID(categoryID);
        }
    }
}
