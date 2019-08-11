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
            // Primary Key Setting

            modelBuilder.Entity<Authors>().HasKey(t => new { t.Au_id });
            modelBuilder.Entity<Discounts>().HasKey(t => new { t.fakeId });
            modelBuilder.Entity<Employees>().HasKey(t => new { t.Emp_id });
            modelBuilder.Entity<Jobs>().HasKey(t => new { t.Job_id });
            modelBuilder.Entity<Pub_info>().HasKey(t => new { t.Pub_id });
            modelBuilder.Entity<Publishers>().HasKey(t => new { t.Pub_id });
            modelBuilder.Entity<Roysched>().HasKey(t => new { t.FakeId });
            modelBuilder.Entity<Sales>().HasKey(t => new { t.Stor_id, t.Ord_num, t.Title_id });
            modelBuilder.Entity<Stores>().HasKey(t => new { t.Stor_id });
            modelBuilder.Entity<Titleauthor>().HasKey(t => new { t.Au_id, t.Title_id });
            modelBuilder.Entity<Titles>().HasKey(t => new { t.Title_id });

            //modelBuilder.Entity<Pub_info>()
            //.Property(t => t.Logo);

            //modelBuilder.Entity<Pub_info>()
            //    .HasMany<byte[]>(t => t.Logo);

            // foreign key setting

            modelBuilder.Entity<Discounts>().HasOne(d => d.Store).WithMany(s => s.Discounts).HasForeignKey(d => d.Stor_id);

            modelBuilder.Entity<Employees>().HasOne(e => e.Job).WithMany(j => j.Employees).HasForeignKey(e => e.Job_id);
            modelBuilder.Entity<Employees>().HasOne(e => e.Publisher).WithMany(p => p.Employees).HasForeignKey(e => e.Pub_id);

            modelBuilder.Entity<Pub_info>().HasOne(pi => pi.Publisher).WithMany(p => p.Pub_info).HasForeignKey(pi => pi.Pub_id);

            modelBuilder.Entity<Roysched>().HasOne(r => r.Title).WithMany(t => t.Royscheds).HasForeignKey(r => r.Title_id);

            modelBuilder.Entity<Sales>().HasOne(s => s.Store).WithMany(s => s.Sales).HasForeignKey(s => s.Stor_id);
            modelBuilder.Entity<Sales>().HasOne(s => s.Title).WithMany(t => t.Sales).HasForeignKey(s => s.Title_id);

            modelBuilder.Entity<Titleauthor>().HasOne(ta => ta.Author).WithMany(a => a.Titleauthors).HasForeignKey(ta => ta.Au_id);
            modelBuilder.Entity<Titleauthor>().HasOne(ta => ta.Title).WithMany(t => t.Titleauthors).HasForeignKey(ta => ta.Title_id);

            modelBuilder.Entity<Titles>().HasOne(t => t.Publisher).WithMany(p => p.Titles).HasForeignKey(t => t.Pub_id);
          
        }


        public DbSet<Authors> Authors { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Pub_info> Pub_info { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Titleauthor> Titleauthors { get; set; }
        public DbSet<Titles> Titles { get; set; }

        
    }
}