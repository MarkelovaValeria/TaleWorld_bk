using Domain.Entities;
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
    public class TypeTasksConfiguration : IEntityTypeConfiguration<TypeTasks>
    {
        public void Configure(EntityTypeBuilder<TypeTasks> builder)
        {
            builder.HasKey(type => type.Id);

            builder.Property(type => type.Type).IsRequired();

            new TypeSeeder().Seed(builder);
        }
    }
}
