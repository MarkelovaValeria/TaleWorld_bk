using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class TaskSeeder : ISeeder<TasksLocation>
    {
        private static readonly List<TasksLocation> tasks = new()
        {
            new TasksLocation
            {
                Id = 1,
                SubTypeId = 1,
                TypeId = 1,
                Question = "Знайди правильне речення"
            }
        };

        public void Seed(EntityTypeBuilder<TasksLocation> builder) => builder.HasData(tasks);
    }
}
