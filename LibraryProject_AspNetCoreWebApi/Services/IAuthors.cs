using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Models;
namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IAuthors
    {
        IQueryable<Authors> GetAuthors();
        Authors GetAuthor(string id);
        void AddAuthor(Authors author);
        void UpdateAuthor(Authors author);
        void DeleteAuthor(string id);

    }
}
