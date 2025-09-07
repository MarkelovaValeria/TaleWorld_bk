using Application.Courses.Queries.GetCoursesById;
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

        public async Task<User> GetTeacherByCourseIdAsync(int courseId)
        {
            var course = await _context.Courses
                .AsNoTracking()
                .FirstOrDefaultAsync(course => course.Id == courseId);

            return await _context.Users.FirstOrDefaultAsync(user => user.Id == course.TeacherId);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users
        .AsNoTracking()
        .FirstOrDefaultAsync(user => user.Email == email);

            if (user == null)
            {
                return null;
            }
            Console.WriteLine(user.Email);

            return user;
        }

        public async Task<User> GetUserByFullNameAsync(string name, string surname)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Name == name && user.Surname == surname);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
        }
    }
}
