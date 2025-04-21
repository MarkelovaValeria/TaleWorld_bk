using Domain.Entities;
using Domain.Entities.Admin.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class LocationSeeder : ISeeder<Location>
    {
        private static readonly List<Location> locations = new()
        {
            new Location
            {
                Id = 1,
                MapId = 1,
                TaskQuestionsId = 1,
                Background = "new",
                Text = "text"
            }
        };

        public void Seed(EntityTypeBuilder<Location> builder) => builder.HasData(locations);
    }
}
