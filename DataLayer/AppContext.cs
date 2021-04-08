using Microsoft.EntityFrameworkCore;
using Models;
using SchoolWebAppusingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<ClassModel> ClassModel { get; set; }
        public DbSet<TeacherModel> TeacherModel { get; set; }

    }
}
