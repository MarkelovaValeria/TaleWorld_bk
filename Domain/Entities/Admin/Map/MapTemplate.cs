using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Admin.Map
{
    public class MapTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? BackgroundTitle { get; set; }
        public List<LocationTemplate> Locations { get; set; } = new();

    }
}
