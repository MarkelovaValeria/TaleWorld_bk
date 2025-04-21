using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TWDbContext _context;

        public CourseRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddCourse(Course course)
        {
            await _context.courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }
    }
}
