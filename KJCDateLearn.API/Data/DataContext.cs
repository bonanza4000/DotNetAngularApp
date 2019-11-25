using System;
using Microsoft.EntityFrameworkCore;
using KJCDateLearn.API.Models; 

namespace KJCDateLearn.API.Data
{
    // test
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}
