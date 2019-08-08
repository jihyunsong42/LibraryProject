using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface ITitleauthor
    {
        IQueryable<Titleauthor> GetTitleauthors();
        Titleauthor GetTitleauthor(string au_id, string title_id);
        void AddTitleauthor(Titleauthor Titleauthor);
        void UpdateTitleauthor(Titleauthor Titleauthor);
        void DeleteTitleauthor(string au_id, string title_id);
    }
}
