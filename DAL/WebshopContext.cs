using DAL.DALEntitysModels;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class WebshopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<BasketPosition> BasketPositions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Webshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Webshop2; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductGroup>().HasMany(x=>x.Products).WithOne(x=>x.Group).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<UserGroup>().HasMany(x => x.Users).WithOne(x=>x.Group).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<User>().HasMany(x=>x.Orders).WithOne(x=>x.User).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Order>().HasMany(x=>x.Positions).WithOne(x=>x.Order).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Product>().HasMany(x => x.BasketPositions).WithOne(x=>x.Product).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(x => x.BasketPositions).WithOne(x=>x.User).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductGroup>().HasMany(x => x.Products).WithOne(x=>x.Group).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
