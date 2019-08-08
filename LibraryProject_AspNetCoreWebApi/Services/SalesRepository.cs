using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class SalesRepository : ISales
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public SalesRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }
        
        public IQueryable<Sales> GetSales()
        {
            return bookstoreDbContext.Sales;
        }

        public Sales GetSale(string stor_id, string ord_num, string title_id)
        {
            var sale = bookstoreDbContext.Sales.SingleOrDefault(i => (
                i.Stor_id == stor_id &&
                i.Ord_num == ord_num &&
                i.Title_id == title_id
            ));
            return sale;
        }

        public void AddSale(Sales sale)
        {
            bookstoreDbContext.Add(sale);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateSale(Sales sale)
        {
            bookstoreDbContext.Update(sale);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteSale(string stor_id, string ord_num, string title_id)
        {
            object[] p_keys = { stor_id, ord_num, title_id };
            var item = bookstoreDbContext.Publishers.Find(p_keys);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }



    }
}
