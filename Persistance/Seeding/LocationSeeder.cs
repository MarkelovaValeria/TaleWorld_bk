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
    public class LocationSeeder : ISeeder<LocationTemplate>
    {
        private static readonly List<LocationTemplate> locations = new()
        {
            new LocationTemplate
            {
                Id = 1,
                MapTemplateId = 1,
                Background = "/images/Location3.jpg",
                Text = "text"
            }
        };

        public void Seed(EntityTypeBuilder<LocationTemplate> builder) => builder.HasData(locations);
    }
}
