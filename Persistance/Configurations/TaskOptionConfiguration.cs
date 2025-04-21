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
    public class TaskOptionConfiguration : IEntityTypeConfiguration<TaskOptions>
    {
        public void Configure(EntityTypeBuilder<TaskOptions> builder)
        {
            builder.HasKey(option => option.Id);

            builder.Property(option => option.OptionText).IsRequired().HasMaxLength(100);
            builder.Property(option => option.IsCorrect).IsRequired();
            builder.Property(option => option.TaskQuestionsId).IsRequired();

            new TaskOptionSeeder().Seed(builder);

        }
    }
}
