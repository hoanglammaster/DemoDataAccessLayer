using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.DAL
{
    public class DAO
    {
        public static SqlConnection GetConnnection()
        {
            string serverName = "localhost";
            string databaseName = "Northwind";
            string userName = "sa";
            string password = "123";
            string connnectionString = $"server={serverName};database={databaseName};user={userName};password={password}";

            return new SqlConnection(connnectionString);
        }
        public static DataTable GetOneTableDataBySql(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, DAO.GetConnnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
