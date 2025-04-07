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
    public class TypeSeeder : ISeeder<TypeTasks>
    {
        private static readonly List<TypeTasks> typeTasks = new()
        {
            new TypeTasks
            {
                Id = 1,
                Type = TypeTask.Grammar
            },
            new TypeTasks
            {
                Id = 2,
                Type = TypeTask.Listening
            },
            new TypeTasks
            {
                Id = 3,
                Type = TypeTask.Reading
            },
            new TypeTasks
            {
                Id = 4,
                Type = TypeTask.Writing
            },
            new TypeTasks
            {
                Id= 5,
                Type = TypeTask.Game
            }
        };

        public void Seed(EntityTypeBuilder<TypeTasks> builder) => builder.HasData(typeTasks);
    }
}
