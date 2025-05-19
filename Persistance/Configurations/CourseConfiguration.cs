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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(course => course.Id);

            builder.Property(course => course.Title).IsRequired().HasMaxLength(50);
            builder.Property(course => course.TeacherId).IsRequired();
            builder.Property(course => course.CoursePhoto).IsRequired(false);

            new CourseSeeder().Seed(builder);
        }
    }
}
