using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lessons
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int? TemplateId { get; set; }
        public LocationTemplate? Template { get; set; }

        public List<LessonTask> LessonTasks { get; set; } = new();
    }
}
