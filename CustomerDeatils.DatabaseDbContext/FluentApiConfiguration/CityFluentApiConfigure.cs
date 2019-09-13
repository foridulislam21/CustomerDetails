using System;
using System.Collections.Generic;
using System.Text;
using CustomerDeatils.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerDeatils.DatabaseDbContext.FluentApiConfiguration
{
    public class CityFluentApiConfigure : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name).IsRequired();
        }
    }
}