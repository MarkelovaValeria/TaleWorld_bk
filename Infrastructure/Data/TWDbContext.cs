using Domain.Entities;
using Domain.Entities.Admin.Map;
using Microsoft.EntityFrameworkCore;
using Persistance.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class TWDbContext : DbContext
    {
        public TWDbContext(DbContextOptions<TWDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());


        }

        public DbSet<User> Users { get; set; }
        public DbSet<TypeTasks> TypeTasks { get; set; }
        public DbSet<TaskSubType> TaskSubType { get; set; }
        public DbSet<TasksLocation> TasksLocations { get; set; }
        public DbSet<TaskOptions> TaskOptions { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Map> Maps { get; set; }

    }
}
