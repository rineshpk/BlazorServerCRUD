using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorServerCRUD.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerCRUD.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employee");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employee/{id}");
        }

        public async Task DeleteEmployee(int id)
        {
            await _httpClient.DeleteAsync($"api/employee/{id}");
        }

        public async Task AddEmployee(Employee employee)
        {
            await _httpClient.PostJsonAsync($"api/employee",employee);
        }

         public async Task UpdateEmployee(Employee employee)
        {
            await _httpClient.PutJsonAsync($"api/employee",employee);
        }

    }
}