using HomeworkEduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkEduHome.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
