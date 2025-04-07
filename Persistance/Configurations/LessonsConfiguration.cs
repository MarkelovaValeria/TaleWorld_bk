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
    public class LessonsConfiguration : IEntityTypeConfiguration<Lessons>
    {
        public void Configure(EntityTypeBuilder<Lessons> builder)
        {
            builder.HasKey(lesson => lesson.Id);
            builder.Property(lesson => lesson.Title).IsRequired().HasMaxLength(50);
            builder.Property(lesson => lesson.CourseId).IsRequired().HasMaxLength(50);
            builder.Property(lesson => lesson.MapId).IsRequired();

            new LessonSeeder().Seed(builder);
        }
    }
}
