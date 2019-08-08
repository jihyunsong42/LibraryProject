using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class StoresRepository : IStores
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public StoresRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }

        

        public IQueryable<Stores> GetStores()
        {
            return bookstoreDbContext.Stores;
        }

        public Stores GetStore(string id)
        {
            var store = bookstoreDbContext.Stores.SingleOrDefault(i => i.Stor_id == id);
            return store;
        }

        public void AddStore(Stores store)
        {
            bookstoreDbContext.Add(store);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateStore(Stores store)
        {
            bookstoreDbContext.Update(store);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteStore(string id)
        {
            var item = bookstoreDbContext.Stores.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }


    }
}

