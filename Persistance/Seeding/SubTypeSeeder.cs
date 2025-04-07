using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Npgsql.Internal.Postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Seeding
{
    public class SubTypeSeeder : ISeeder<TaskSubType>
    {
        private static readonly List<TaskSubType> subType = new()
        {
            new TaskSubType
            {
                Id = 1,
                TypeId = 1,
                SubType = "Fill in the blanks"
            },
            new TaskSubType
            {
                Id = 2,
                TypeId = 1,
                SubType = "Multiple choice"
            },
            new TaskSubType
            {
                Id = 3,
                TypeId = 1,
                SubType = "Sentence building",
            },
            new TaskSubType
            {
                Id = 4,
                TypeId = 1,
                SubType = "Error correction",
            }
        };

        public void Seed(EntityTypeBuilder<TaskSubType> builder) => builder.HasData(subType);
    }
}
