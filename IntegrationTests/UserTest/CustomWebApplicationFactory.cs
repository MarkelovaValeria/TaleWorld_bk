using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Domain.Entities.Enum;
using Domain.Entities;

namespace IntegrationTests.UserTest
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        public CustomWebApplicationFactory() { }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Видаляємо реєстрацію продакшн-контексту
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<TWDbContext>));
                if (descriptor != null)
                    services.Remove(descriptor);

                // Додаємо InMemory БД для тестів
                services.AddDbContext<TWDbContext>(options =>
                {
                    options.UseInMemoryDatabase("TestDb");
                });

                // Опційно — ініціалізуємо БД
                using var scope = services.BuildServiceProvider().CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<TWDbContext>();
                context.Database.EnsureCreated();

                // Вставляємо тестові дані
                context.Users.Add(new User
                {
                    Name = "John",
                    Surname = "Doe",
                    Email = "john.doe@example.com",
                    PasswordHash = "hashedpassword123",
                    Role = UserRole.Teacher,
                    TeachingLanguage = "English"
                });

                context.Users.Add(new User
                {
                    Name = "Jane",
                    Surname = "Smith",
                    Email = "jane.smith@example.com",
                    PasswordHash = "hashedpassword456",
                    Role = UserRole.Student,
                    TeachingLanguage = ""
                });

                context.SaveChanges();
            });
        }
    }
}
