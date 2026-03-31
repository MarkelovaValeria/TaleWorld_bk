using Domain.Entities;
using Domain.Entities.Admin.Map;
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
    public class LessonTaskConfiguration : IEntityTypeConfiguration<LessonTask>
    {
        public void Configure(EntityTypeBuilder<LessonTask> builder)
        {
            builder.HasKey(lt => lt.Id);

            builder
                .HasOne(lt => lt.Lesson)
                .WithMany(l => l.LessonTasks)
                .HasForeignKey(l => l.LessonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(lt => lt.TaskQuestion)
                .WithMany(tq => tq.LessonTasks)
                .HasForeignKey(l => l.TaskQuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            new LessonTaskSeeder().Seed(builder);
        }
    }
}
