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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Authors>()
            //.HasOne<Titleauthor>(a => a.Titleauthor)
            //.WithMany(t => t.Authors)
            //.HasForeignKey(t => t.Au_id);

            //modelBuilder.Entity<Titles>()
            //.HasOne<Titleauthor>(t => t.Titleauthor)
            //.WithMany(t => t.Titles)
            //.HasForeignKey(t => t.Title_id);


            modelBuilder.Entity<Sales>()
                .HasKey(t => new { t.Stor_id, t.Ord_num, t.Title_id });
            modelBuilder.Entity<Titleauthor>()
                .HasKey(t => new { t.Au_id, t.Title_id });
            modelBuilder.Entity<Discounts>()
            .HasKey(t => new { t.fakeId });
            modelBuilder.Entity<Roysched>()
            .HasKey(t => new { t.FakeId });
            modelBuilder.Entity<Pub_info>()
            .Property(t => t.Logo)
            .HasColumnType("image");
            //modelBuilder.Entity<Pub_info>()
            //    .HasMany<byte[]>(t => t.Logo);
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