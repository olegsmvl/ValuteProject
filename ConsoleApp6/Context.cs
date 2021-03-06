using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ModelCourse;

namespace Server
{
    public class Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Valute> Valutes { get; set; }
        public DbSet<ValuteValue> ValuteValues { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=course.db");
        }
    }
}
