using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class TitlesRepository : ITitles
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public TitlesRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }

        public IQueryable<Titles> GetTitles()
        {
            return bookstoreDbContext.Titles;
        }

        public Titles GetTitle(string id)
        {
            var title = bookstoreDbContext.Titles.SingleOrDefault(i => i.Title_id == id);
            return title;
        }

        public IQueryable<Titles> GetTitlesByName(string titleName)
        {
            string sp = "uspGetTitleByKeywordAsc, " + titleName;
            bookstoreDbContext.Database.
        }

        public void AddTitle(Titles title)
        {
            bookstoreDbContext.Add(title);
            bookstoreDbContext.SaveChanges(true);
        }

        public void UpdateTitle(Titles title)
        {
            bookstoreDbContext.Update(title);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteTitle(string id)
        {
            var item = bookstoreDbContext.Titles.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }
        
    }


}
