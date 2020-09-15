using System.Collections.Generic;
using BlazorServerCRUD.Models;

namespace BlazorServerCRUD.Api.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}