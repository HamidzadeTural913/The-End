using BigExam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigExam.DAL
{
    public class AppDbContext:DbContext
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            _options = options;
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
    }
}
