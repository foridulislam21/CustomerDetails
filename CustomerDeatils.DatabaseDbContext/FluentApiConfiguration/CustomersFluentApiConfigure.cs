using System;
using System.Collections.Generic;
using System.Text;
using CustomerDeatils.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerDeatils.DatabaseDbContext.FluentApiConfiguration
{
    internal class CustomersFluentApiConfigure : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Address).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.MobileNo).IsRequired();
        }
    }
}