using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class Pub_infoRepository : IPub_info
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public Pub_infoRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }



        public IQueryable<Pub_info> GetPub_infos()
        {
            return bookstoreDbContext.Pub_info;
        }

        public Pub_info GetPub_info(string id)
        {
            var info = bookstoreDbContext.Pub_info.SingleOrDefault(i => i.Pub_id == id);
            return info;
        }

        public void AddPub_info(Pub_info pub_info)
        {
            bookstoreDbContext.Add(pub_info);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdatePub_info(Pub_info pub_info)
        {
            bookstoreDbContext.Update(pub_info);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeletePub_info(string id)
        {
            var item = bookstoreDbContext.Pub_info.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }


    }
}
