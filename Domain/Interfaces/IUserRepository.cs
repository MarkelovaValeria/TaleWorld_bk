using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string fullname);
        Task AddUserAsync(User user);
        Task SaveChangesAsync();
    }
}
