using LibraryProject_AspNetCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Data
{
    public class BookstoreDbContext : DbContext
    {

        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {

        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Pub_info> Pub_infos { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Titleauthor> Titleauthors { get; set; }
        public DbSet<Titles> Titles { get; set; }

        
    }
}