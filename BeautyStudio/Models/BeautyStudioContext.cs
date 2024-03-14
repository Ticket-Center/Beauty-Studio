using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Models
{
    internal class BeautyStudioContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Appointments> Appointments { get; set; } = null!;
        public DbSet<Employee> Employee { get; set; } = null!;
        public DbSet<EmployeeTypes> EmployeeTypes { get; set; } = null!;
        public DbSet<ServiceTypes> ServiceTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("jdbc:mysql://localhost:3306/beauty_studio");
        }
    }
}
