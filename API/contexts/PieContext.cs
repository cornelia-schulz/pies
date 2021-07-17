using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.contexts
{
    public class PieContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        public PieContext(DbContextOptions<PieContext> options)
          :base(options)
          {
            Database.EnsureCreated();
          }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<Pie>()
            .HasData(
              new Pie()
              {
                Id = 1,
                Name = "Steak and Mushroom Pie",
                PieTypeId = 1,
                UserId = 1,
                DateCreated = new DateTime(2021, 07, 01)
              },
              new Pie()
              {
                Id = 2,
                Name = "Apple Pie",
                PieTypeId = 2,
                UserId = 1,
                DateCreated = new DateTime(2021, 06, 03)
              },
              new Pie()
              {
                Id = 3,
                Name = "Mexican Pie",
                PieTypeId = 3,
                UserId = 1,
                DateCreated = new DateTime(2020, 05, 16)
              },
              new Pie()
              {
                Id = 4,
                Name = "Bacon and Egg",
                PieTypeId = 2,
                UserId = 1,
                DateCreated = new DateTime(2021, 04, 11)
              }
            );
        }
    }
}