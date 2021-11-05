using AzureWebAppSqlDemo.Interfaces;
using AzureWebAppSqlDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebAppSqlDemo.Services
{
    public class Products: IProduct
    {
        public List<Product> GetProducts(string connection)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Products", sqlConnection);
            sqlDataAdapter.Fill(dt);
            List<Product> productLst = new List<Product>();
            productLst = (from DataRow dr in dt.Rows
                           select new Product()
                           {
                               Id = Convert.ToInt32(dr["Id"]),
                               Name = dr["Name"].ToString(),
                           }).ToList();
            return productLst;

        }
    }
}
