using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IJobs
    {
        IQueryable<Jobs> GetJobs();
        Jobs GetJob(short id);
        void AddJob(Jobs job);
        void UpdateJob(Jobs job);
        void DeleteJob(short id);
    }
}
