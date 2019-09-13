using System;
using System.Collections.Generic;
using System.Text;
using CustomerDeatils.DatabaseDbContext.FluentApiConfiguration;
using CustomerDeatils.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerDeatils.DatabaseDbContext
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=CustomerDetails;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryFluentApiConfigure());
            modelBuilder.ApplyConfiguration(new CityFluentApiConfigure());
            modelBuilder.ApplyConfiguration(new CustomersFluentApiConfigure());
        }
    }
}