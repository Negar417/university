using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityNG.models;

namespace UniversityNG.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Students> StudentB => Set<Students>(); 
        public DbSet<Course> Course => Set<Course>(); 
    }
}
