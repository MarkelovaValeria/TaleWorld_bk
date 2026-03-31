using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        public int? CreatedById { get; set; }
        public User? CreatedBy { get; set; }
        public int? TemplateId { get; set; }
        public MapTemplate? Template { get; set; }
        public List<Lessons> Lessons { get; set; } = new();
        public List<StudentCourse> StudentCourses { get; set; } = new();
    }
}
