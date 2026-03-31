using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LessonTask
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public Lessons Lesson { get; set; }

        public int TaskQuestionId { get; set; }
        public TasksQuestions TaskQuestion { get; set; }
    }
}
