using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_16.Models;

namespace Assignment_16.Data
{
    public class MyTaskDbContext : DbContext
    {
        public MyTaskDbContext (DbContextOptions<MyTaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment_16.Models.MyTask> MyTask { get; set; } = default!;
    }
}
