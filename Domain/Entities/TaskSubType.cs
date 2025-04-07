using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaskSubType
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string SubType { get; set; }

        public TypeTasks Type { get; set; }
        public List<TasksLocation> TaskLocations { get; set; } = new();
    }
}
