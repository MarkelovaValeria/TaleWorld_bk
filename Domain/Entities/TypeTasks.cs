using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TypeTasks
    {
        public int Id { get; set; }
        public TypeTask Type { get; set; }

        public List<TaskSubType> SubTypes { get; set; } = new();

    }
}
