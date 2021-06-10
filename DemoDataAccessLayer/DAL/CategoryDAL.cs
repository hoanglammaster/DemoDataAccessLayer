using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.DAL
{
    public class CategoryDAL
    {

        public static DataTable GetAllCategory()
        {
            string query = "SELECT * FROM Categories";
            return DAO.GetOneTableDataBySql(query);
        }
    }
}
