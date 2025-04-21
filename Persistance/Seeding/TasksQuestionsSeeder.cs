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
    public class TasksQuestionsSeeder : ISeeder<TasksQuestions>
    {
        private static readonly List<TasksQuestions> tasks = new()
        {
            new TasksQuestions
            {
                Id = 1,
                TypeId = 1,
                SubTypeId = 2,
                Question = "Choose the correct form: He ___ to the gym every day."
            }
        };

        public void Seed(EntityTypeBuilder<TasksQuestions> builder) => builder.HasData(tasks);
    }
}
