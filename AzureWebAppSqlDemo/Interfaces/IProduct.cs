using AzureWebAppSqlDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebAppSqlDemo.Interfaces
{
    public interface IProduct
    {
        List<Product> GetProducts(string connection);
    }
}
