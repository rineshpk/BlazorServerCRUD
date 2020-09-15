using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerCRUD.Models
{
    public class Employee
    {
        public int EmployeeID{get;set;}
        public string EmployeeName{get;set;}
        [DataType(DataType.Date)]
        public DateTime DateOfBirth{get;set;}
        public Gender Gender{get;set;}
        public int DepartmentID{get;set;}
        public Department Department{get;set;}
    }
}
