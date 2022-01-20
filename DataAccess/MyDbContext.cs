using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample_exam.Entities;

namespace Sample_exam.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }

        public MyDbContext()
        {
            Reservations = Set<Reservation>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost;Database=asp_project;Trusted_Connection=True;");
        }
    }
}

