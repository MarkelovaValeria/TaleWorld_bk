using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Admin.Map
{
    public class Location
    {
        public int Id { get; set; }
        public string Background { get; set; }
        public string Text { get; set; }
        public int MapId  { get; set; }
        public Map Map { get; set; }
        public int? TaskQuestionsId { get; set; }
        public TasksQuestions TaskQuestions { get; set; }


    }
}
