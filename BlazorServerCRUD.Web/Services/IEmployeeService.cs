using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerCRUD.Models;

namespace BlazorServerCRUD.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task DeleteEmployee(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
    }
}