using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class TaskOptionSeeder : ISeeder<TaskOptions>
    {
        private static readonly List<TaskOptions> options = new()
        {
            new TaskOptions
            {
                Id = 1,
                TaskQuestionsId = 1,
                OptionText = "going",
                IsCorrect = true
            },
            new TaskOptions
            {
                Id = 2,
                TaskQuestionsId = 1,
                OptionText = "goes",
                IsCorrect = false
            },
            new TaskOptions
            {
                Id = 3,
                TaskQuestionsId = 1,
                OptionText = "gone",
                IsCorrect = false
            },
            new TaskOptions
            {
                Id = 4,
                TaskQuestionsId = 1,
                OptionText = "go",
                IsCorrect = false
            },
        };

        public void Seed(EntityTypeBuilder<TaskOptions> builder) => builder.HasData(options);

    }
}
