﻿using Domain.Entities;
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
        public TWDbContext() : base() { }
        public TWDbContext(DbContextOptions<TWDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TypeTasksConfiguration());
            modelBuilder.ApplyConfiguration(new TasksQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new TaskOptionConfiguration());
            modelBuilder.ApplyConfiguration(new TaskSubTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MapConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new LessonsConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TypeTasks> TypeTasks { get; set; }
        public DbSet<TaskSubType> TaskSubType { get; set; }
        public DbSet<TasksQuestions> TasksQuestions { get; set; }
        public DbSet<TaskOptions> TaskOptions { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        /* public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<TypeTasks> TypeTasks { get; set; }
         public virtual DbSet<TaskSubType> TaskSubType { get; set; }
         public virtual DbSet<TasksQuestions> TasksQuestions { get; set; }
         public virtual DbSet<TaskOptions> TaskOptions { get; set; }
         public virtual DbSet<Lessons> Lessons { get; set; }
         public virtual DbSet<Course> courses { get; set; }
         public virtual DbSet<Location> Locations { get; set; }
         public virtual DbSet<Map> Maps { get; set; }
         public virtual DbSet<StudentCourse> StudentCourses { get; set; }*/

    }
}
