using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface ISales
    {
        IQueryable<Sales> GetSales();
        Sales GetSale(string stor_id, string ord_num, string title_id);
        void AddSale(Sales sales);
        void UpdateSale(Sales sales);
        void DeleteSale(string stor_id, string ord_num, string title_id);

    }
}