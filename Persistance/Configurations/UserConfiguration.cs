using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Name).IsRequired().HasMaxLength(50);
            builder.Property(user => user.Surname).IsRequired().HasMaxLength(50);
            builder.Property(user => user.PasswordHash).IsRequired().HasMaxLength(150);
            builder.Property(user => user.RefreshToken).HasMaxLength(500).IsRequired(false);
            builder.Property(user => user.Email).IsRequired().HasMaxLength(150);
            builder.Property(user => user.Role).IsRequired();
            builder.Property(user => user.TeachingLanguage).IsRequired(false);
            builder.Property(user => user.Photo).IsRequired(false);

            new UserSeeder().Seed(builder);

        }
    }
}
