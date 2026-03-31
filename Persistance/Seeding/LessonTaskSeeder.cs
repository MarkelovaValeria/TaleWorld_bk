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
    public class LessonTaskSeeder : ISeeder<LessonTask>
    {
        private static readonly List<LessonTask> lt = new()
        {
            new LessonTask
            {
                Id = 1,
                LessonId = 1,
                TaskQuestionId = 1,
            }
        };

        public void Seed(EntityTypeBuilder<LessonTask> builder) => builder.HasData(lt);
    }
}
