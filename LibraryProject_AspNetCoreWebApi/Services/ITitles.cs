using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface ITitles
    {
        IQueryable<Titles> GetTitles();
        Titles GetTitle(string id);
        IQueryable<TitlesByKeyword> GetTitlesByName();
        IQueryable<TitlesByKeyword> GetTitlesByName(string titleName);
        IQueryable<TitlesByKeyword> GetTitlesByAuthorName();
        IQueryable<TitlesByKeyword> GetTitlesByAuthorName(string authorName);
        void AddTitle(Titles title);
        void UpdateTitle(Titles title);
        void DeleteTitle(string id);
    }
}
