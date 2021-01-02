using istanfind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace istanfind.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<FunPlace> FunPlace { get; set; }

        public DbSet<HistoricalPlace> HistoricalPlace { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Park> Park { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Hotel>().HasData(
                new Hotel() { Id = 1, Adress = "adresss", AdressUrl = "https://hoohle.com", DataText = "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", ImageUrl = "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", Name = "ShangitiLa", PhoneNumber = "2125641235", Score = 0, TitleText = "Yat aşşaa", WebSiteUrl = "www.bombabomba.com" },
                new Hotel() { Id = 2, Adress = "adresss", AdressUrl = "https://hoohle.com", DataText = "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", ImageUrl = "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", Name = "ShangitiLa", PhoneNumber = "2125641235", Score = 0, TitleText = "Yat aşşaa", WebSiteUrl = "www.bombabomba.com" },
                new Hotel() { Id = 3, Adress = "adresss", AdressUrl = "https://hoohle.com", DataText = "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", ImageUrl = "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", Name = "ShangitiLa", PhoneNumber = "2125641235", Score = 0, TitleText = "Yat aşşaa", WebSiteUrl = "www.bombabomba.com" }
                );
            builder.Entity<FunPlace>().HasData(
                  new FunPlace() { Id = 1, Adress = "adresss", AdressUrl = "https://hoohle.com", DataText = "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", ImageUrl = "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", Name = "ShangitiLa", PhoneNumber = "2125641235", Score = 0, TitleText = "Yat aşşaa", WebSiteUrl = "www.bombabomba.com" }
                );
        }
    }
}
