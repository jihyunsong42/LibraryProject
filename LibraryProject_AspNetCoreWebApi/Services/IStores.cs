using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IStores
    {
        IQueryable<Stores> GetStores();
        Stores GetStore(string id);
        void AddStore(Stores store);
        void UpdateStore(Stores store);
        void DeleteStore(string id);
    }
}
