using istanfind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace istanfind.Data
{
    public class ApplicationDbContext : IdentityDbContext
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
    }
}
