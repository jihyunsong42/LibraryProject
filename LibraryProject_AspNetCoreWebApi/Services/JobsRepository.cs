using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class JobsRepository : IJobs
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public JobsRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }

        

        public IQueryable<Jobs> GetJobs()
        {
            return bookstoreDbContext.Jobs;
        }

        public Jobs GetJob(short id)
        {
            var job = bookstoreDbContext.Jobs.SingleOrDefault(i => i.Job_id == id);
            return job;
        }

        public void AddJob(Jobs job)
        {
            bookstoreDbContext.Add(job);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateJob(Jobs job)
        {
            bookstoreDbContext.Update(job);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteJob(short id)
        {
            var item = bookstoreDbContext.Jobs.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }


    }
}
