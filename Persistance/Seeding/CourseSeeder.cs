using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class CourseSeeder : ISeeder<Course>
    {
        private static readonly List<Course> courses = new()
        {
            new Course
            {
                Id = 1,
                TeacherId = 1,
                Title = ""
            }
        };

        public void Seed(EntityTypeBuilder<Course> builder) => builder.HasData(courses);
    }
}
