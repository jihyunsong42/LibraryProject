using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class AuthorsRepository : IAuthors
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public AuthorsRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }



        public IQueryable<Authors> GetAuthors()
        {
            return bookstoreDbContext.Authors;
        }

        public Authors GetAuthor(string id)
        {
            var author = bookstoreDbContext.Authors.SingleOrDefault(i => i.Au_id == id);
            return author;
        }

        public void AddAuthor(Authors author)
        {
            bookstoreDbContext.Add(author);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateAuthor(Authors author)
        {
            bookstoreDbContext.Update(author);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteAuthor(string id)
        {
            var item = bookstoreDbContext.Authors.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);
            
        }



    }
}


