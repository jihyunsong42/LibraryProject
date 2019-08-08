using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class PublishersRepository : IPublishers
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public PublishersRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }



        public IQueryable<Publishers> GetPublishers()
        {
            return bookstoreDbContext.Publishers;
        }

        public Publishers GetPublisher(string id)
        {
            var publisher = bookstoreDbContext.Publishers.SingleOrDefault(i => i.Pub_id == id);
            return publisher;
        }

        public void AddPublisher(Publishers publisher)
        {
            bookstoreDbContext.Add(publisher);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdatePublisher(Publishers publisher)
        {
            bookstoreDbContext.Update(publisher);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeletePublisher(string id)
        {
            var item = bookstoreDbContext.Publishers.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }



    }
}
