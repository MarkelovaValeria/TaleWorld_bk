using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TasksQuestions
    {
        public int Id { get; set; }
        public int SubTypeId { get; set; }
        public int TypeId { get; set; }
        public string Question { get; set; }

        public TaskSubType SubType { get; set; }
        public TypeTasks Type { get; set; }
        public List<TaskOptions> TaskOptions { get; set; } = new();
        public List<Location> Locations { get; set; } = new();
    }
}
