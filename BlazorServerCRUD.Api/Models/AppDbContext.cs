
using System;
using BlazorServerCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Department 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentID = 1, DepartmentName = "Admin" });
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentID = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentID = 3, DepartmentName = "Payroll" });

            //Employee

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 1,
                EmployeeName = "John",
                DateOfBirth = new DateTime(1989, 01, 01),
                Gender = Gender.Male,
                DepartmentID = 1

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 2,
                EmployeeName = "Matt",
                DateOfBirth = new DateTime(1989, 01, 01),
                Gender = Gender.Male,
                DepartmentID = 2

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 3,
                EmployeeName = "Carol",
                DateOfBirth = new DateTime(1989, 01, 01),
                Gender = Gender.Female,
                DepartmentID = 3

            });

             modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 4,
                EmployeeName = "Tony",
                DateOfBirth = new DateTime(1989, 01, 01),
                Gender = Gender.Male,
                DepartmentID = 3

            });
        }

    }
}