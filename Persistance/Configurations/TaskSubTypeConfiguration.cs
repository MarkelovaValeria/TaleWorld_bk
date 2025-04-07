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
    public class TaskSubTypeConfiguration : IEntityTypeConfiguration<TaskSubType>
    {
        public void Configure(EntityTypeBuilder<TaskSubType> builder)
        {
            builder.HasKey(subtype => subtype.Id);

            builder.Property(subtype => subtype.TypeId).IsRequired();
            builder.Property(subtype => subtype.SubType).IsRequired().HasMaxLength(50);

            new SubTypeSeeder().Seed(builder);
        }
    }
}
