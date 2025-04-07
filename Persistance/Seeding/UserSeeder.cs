using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistance.Seeding
{
    public class UserSeeder : ISeeder<User>
    {
        private static readonly List<User> users = new()
        {
            new User
            {
                Id = 1,
                Name = "Name1",
                Surname = "Surname1",
                PasswordHash = "12345",
                Email = "teacher@gmail.com",
                Role = UserRole.Teacher,
                TeachingLanguage = "English"
            },

            new User
            {
                Id = 2,
                Name = "Name2",
                Surname = "Surname2",
                PasswordHash = "123456",
                Email = "student@gmail.com",
                Role = UserRole.Student,
            }
        };
        public void Seed(EntityTypeBuilder<User> builder) => builder.HasData(users);
    }
}
