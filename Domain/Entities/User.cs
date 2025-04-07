using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PasswordHash { get; set; }
        public string? RefreshToken { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public string? TeachingLanguage { get; set; }
       
        public List<Course> Courses { get; set; } = new();

        public void Validate()
        {
            if (Role == UserRole.Teacher && string.IsNullOrEmpty(TeachingLanguage))
            {
                throw new InvalidOperationException("Викладач повинен мати вказану мову, яку викладає.");
            }
        }
    }
}
