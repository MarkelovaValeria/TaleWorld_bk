using Domain.Entities;
using Domain.Entities.Admin.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class MapSeeder : ISeeder<Map>
    {
        private static readonly List<Map> maps = new()
        {
            new Map
            {
                Id = 1,
                BackgroundTitle = "шлях",
                Description = "опис світу",
                Name = "TaleWorld",
            }
        };

        public void Seed(EntityTypeBuilder<Map> builder) => builder.HasData(maps);

    }
}
