using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCIntroNET20.Models;

namespace MVCIntroNET20.Data
{
    public class MVCIntroNET20Context : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public MVCIntroNET20Context (DbContextOptions<MVCIntroNET20Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Age = 20, Name = "Kalle", Salary = 20000, Department = "IT" }
                );
        }

    }
}
