using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TWDbContext _context;
        public UserRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _context.Users
        .AsNoTracking()
        .FirstOrDefaultAsync(user => user.Email == email);

            if (user == null)
            {
                throw new InvalidOperationException("Користувач з такою електронною адресою не знайдений.");
            }
            Console.WriteLine(user.Email);

            return user;
        }

        public async Task<User> GetUserByUsernameAsync(string fullname)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Name == fullname || user.Surname == fullname);
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
