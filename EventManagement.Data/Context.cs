using EventManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data
{
    public class Context : DbContext
    {
        //public Context()
        //{
            
        //}
        public Context(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=1234;database=EventManagement");
        //    }
        //}
        public DbSet<User> Users { get; set; }
    }
}