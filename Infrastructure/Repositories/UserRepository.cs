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
