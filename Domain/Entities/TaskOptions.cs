using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaskOptions
    {
        public int Id { get; set; }
        public int TaskQuestionsId { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }

        public TasksQuestions TaskQuestions { get; set; }
    }
}
