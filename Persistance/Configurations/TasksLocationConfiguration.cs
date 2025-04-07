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
    public class TasksLocationConfiguration : IEntityTypeConfiguration<TasksLocation>
    {
        public void Configure(EntityTypeBuilder<TasksLocation> builder)
        {
            builder.HasKey(task => task.Id);

            builder.Property(task => task.TypeId).IsRequired();
            builder.Property(task => task.SubTypeId).IsRequired();
            builder.Property(task => task.Question).IsRequired().HasMaxLength(250);

            new TaskSeeder().Seed(builder);
        }
    }
}
