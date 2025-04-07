using Domain.Entities.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class UserService : IAuth
    {
        private readonly IPassWordHasher _passwordHasher;

        public UserService(IPassWordHasher passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }
        public async Task Register(string name, string surname, string email, string password, UserRole role, string language)
        {
            var hashedPassword = _passwordHasher.Generate(password);
        }
        public async Task Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
