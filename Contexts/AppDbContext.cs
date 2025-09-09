using EFCoreSession1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Contexts
{
    internal class AppDbContext :DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            modelBuilder.Entity<Employee>()
                .Property(E => E.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("EmployeeName");

            modelBuilder.Entity<Employee>().Property(E => E.Age).IsRequired(false);

            modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");

            modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);







        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = AppG03 ; Trusted_Connection = True; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
