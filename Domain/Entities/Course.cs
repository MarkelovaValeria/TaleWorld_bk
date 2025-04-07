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
        public int TeacherId { get; set; }

        public User Teacher { get; set; }
        public List<Lessons> Lessons { get; set; } = new();
    }
}
