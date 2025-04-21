using Domain.Interfaces;
using Infrastructure.Configurations;
using Infrastructure.Data;
using Infrastructure.Extensions;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TWDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            services.Configure<JwtOptions>(configuration.GetSection("JwtOptions"));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPassWordHasher, PasswordHasher>();
            services.AddTransient<IJwtProvider, JwtProvider>();
            services.AddTransient<ITasksRepository, TasksRepository>();
            services.AddTransient<IMapRepository, MapRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ILessonRepository, LessonRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();

            return services;
        }
    }
}
