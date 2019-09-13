using System;
using System.Collections.Generic;
using System.Text;
using CustomerDeatils.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerDeatils.DatabaseDbContext.FluentApiConfiguration
{
    public class CountryFluentApiConfigure : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.CountryCode).IsRequired();
        }
    }
}