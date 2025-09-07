using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int courseId)
        {
            return await _context.Courses
                .FirstOrDefaultAsync(c => c.Id == courseId);
        }

        public async Task<Course> GetCourseByTeacherIdAsync(int teacherId)
        {
            return await _context.Courses
                .FirstOrDefaultAsync(ct => ct.TeacherId == teacherId);
        }

        public async Task<Course> GetCourseByTitleAsync(string title)
        {
            return await _context.Courses
                .FirstOrDefaultAsync(t => t.Title == title);
        }

    }
}
