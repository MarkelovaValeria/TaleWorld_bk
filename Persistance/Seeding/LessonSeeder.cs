using Domain.Entities;
using Domain.Entities.Admin.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class LessonSeeder : ISeeder<Lessons>
    {
        private static readonly List<Lessons> lessons = new()
        {
            new Lessons
            {
                Id = 1,
                CourseId = 1,
                MapId = 1,
                Title = ""
            }
        };

        public void Seed(EntityTypeBuilder<Lessons> builder) => builder.HasData(lessons);
    }
}
