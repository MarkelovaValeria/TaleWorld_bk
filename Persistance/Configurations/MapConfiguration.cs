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
    public class MapConfiguration : IEntityTypeConfiguration<Map>
    {
        public void Configure(EntityTypeBuilder<Map> builder)
        {
            builder.HasKey(map => map.Id);

            builder.Property(map => map.Name).IsRequired(false).HasMaxLength(50);
            builder.Property(map => map.BackgroundTitle).IsRequired().HasMaxLength(250);
            builder.Property(map => map.Description).IsRequired(false).HasMaxLength(450);

            new MapSeeder().Seed(builder);
        }
    }
}
