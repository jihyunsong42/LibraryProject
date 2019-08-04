using LibraryProject_AspNetCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Data
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {

        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Stores> Stores { get; set; }

        
    }
}