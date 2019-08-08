using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IPublishers
    {
        IQueryable<Publishers> GetPublishers();
        Publishers GetPublisher(string id);
        void AddPublisher(Publishers publisher);
        void UpdatePublisher(Publishers publisher);
        void DeletePublisher(string id);

    }
}
