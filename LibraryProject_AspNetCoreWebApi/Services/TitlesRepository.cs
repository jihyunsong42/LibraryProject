using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

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

        public IQueryable<TitlesByKeyword> GetTitlesByName()
        {
            return bookstoreDbContext.TitlesByKeyword.FromSql("uspGetTitleByKeywordAsc @p0", "");
        }

        public IQueryable<TitlesByKeyword> GetTitlesByName(string titleName)
        {
            // 1. Linq Query Method

            //IQueryable<TitlesByKeyword> q =
            //    (from t in bookstoreDbContext.Titles
            //     join ta in bookstoreDbContext.Titleauthors on t.Title_id equals ta.Title_id
            //     join a in bookstoreDbContext.Authors on ta.Au_id equals a.Au_id
            //     join p in bookstoreDbContext.Publishers on t.Pub_id equals p.Pub_id
            //     where EF.Functions.Like(t.Title, "%" + titleName + "%")
            //     orderby t.Title ascending
            //     select new TitlesByKeyword
            //     {
            //         Title = t.Title,
            //         Au_lname = a.Au_lname,
            //         Au_fname = a.Au_fname,
            //         Pub_name = p.Pub_name,
            //         Price = t.Price,
            //         Notes = t.Notes,
            //         Pubdate = t.Pubdate
            //     });

            //return q;

            // 2. Stored Procedure Method

            return bookstoreDbContext.TitlesByKeyword.FromSql("uspGetTitleByKeywordAsc @p0", titleName);
            
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
