using Domain.Entities.Admin.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<LocationTemplate>
    {
        public void Configure(EntityTypeBuilder<LocationTemplate> builder)
        {
            builder.HasKey(location => location.Id);

            builder.Property(location => location.Background).IsRequired().HasMaxLength(250);
            builder.Property(location => location.Text).IsRequired().HasMaxLength(450);
            builder.Property(location => location.MapTemplateId).IsRequired();

            new LocationSeeder().Seed(builder);
        }
    }
}
