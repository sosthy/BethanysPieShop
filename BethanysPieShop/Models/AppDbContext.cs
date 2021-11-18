using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Italian", Description = "Cake de pizza italien" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Indian", Description = "Delice du l'inde aux saveurs incomparables" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cameroonian", Description = "Les tchops du pays qui reveil le spirit" });

            // seed pies
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 1, Name = "Baskess", ShortDescription = "Cake de pizza italien", Price = 22M, CategoryId = 3 });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 2, Name = "Cake Krus", ShortDescription = "Delice du l'inde aux saveurs incomparables", Price = 105M, CategoryId = 3 });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 3, Name = "Ndole Lave", ShortDescription = "Les tchops du pays qui reveil le spirit", Price = 43M, CategoryId = 2 });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 4, Name = "Pizza Scott's", ShortDescription = "Les tchops du pays qui reveil le spirit", Price = 25M, CategoryId = 1 });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = 5, Name = "Manioc Tubercule", ShortDescription = "Les tchops du pays qui reveil le spirit", Price = 500M, CategoryId = 2 });
        }
    }
}
