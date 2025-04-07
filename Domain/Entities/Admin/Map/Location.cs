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
    }
}
