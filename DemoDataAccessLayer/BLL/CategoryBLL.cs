using DemoDataAccessLayer.DAL;
using DemoDataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.BLL
{
    public class CategoryBLL
    {
      
        public List<Category> GetCategories()
        {
            List<Category> listCategories = new List<Category>();
            DataTable dataTable =  CategoryDAL.GetAllCategory();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listCategories.Add(new Category(Int32.Parse(dataRow["CategoryID"].ToString()), dataRow["CategoryName"].ToString(),dataRow["Description"].ToString()));
            }
            return listCategories;
        }
        
    }
}
