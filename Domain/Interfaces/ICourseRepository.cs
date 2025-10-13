using Domain.Entities;
using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task AddCourse(Course course);
        Task<List<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int courseId);
        Task<Course> GetCourseByTitleAsync(string title);
        Task<Course> GetCourseByTeacherIdAsync(int teacherId);

        Task<IEnumerable<Course>> GetCoursesByTeacherIdAsync(int teacherId);
    }
}
