using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.DAL
{
    public class ProductDAL
    {
        public static DataTable GetProductByCategoryID(int categoryID)
        {
            string query = $"SELECT * FROM Products WHERE CategoryID = {categoryID}";
            return DAO.GetOneTableDataBySql(query);
        }
    }
}
