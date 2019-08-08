using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class TitleauthorRepository : ITitleauthor
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public TitleauthorRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }

        

        public IQueryable<Titleauthor> GetTitleauthors()
        {
            return bookstoreDbContext.Titleauthors;
        }

        public Titleauthor GetTitleauthor(string au_id, string title_id)
        {
            var titleauthor = bookstoreDbContext.Titleauthors.SingleOrDefault(i => (
            i.Au_id == au_id &&
            i.Title_id == title_id));
            return titleauthor;
        }

        public void AddTitleauthor(Titleauthor titleauthor)
        {
            bookstoreDbContext.Add(titleauthor);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateTitleauthor(Titleauthor titleauthor)
        {
            bookstoreDbContext.Update(titleauthor);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteTitleauthor(string au_id, string title_id)
        {
            object[] p_keys = { au_id, title_id };
            var item = bookstoreDbContext.Jobs.Find(p_keys);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }


    }
}
