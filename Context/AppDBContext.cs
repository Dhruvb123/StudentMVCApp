using Microsoft.EntityFrameworkCore;
using MVCCourse.Models;
using System;

namespace MVCCourse.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Students> Students { get; set; }
    }
}
