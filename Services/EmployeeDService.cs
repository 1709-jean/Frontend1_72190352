using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UTS.Models;

namespace UTS.Services
{
    public class EmployeeDService : IEmployeeDServices
    {
        private HttpClient _httpClient;
        public EmployeeDService(HttpClient httpClient){
            _httpClient = httpClient;
        }
        public async Task<Employee> GetEmployee (int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return result;
        }

        internal static Task<IEnumerable<Employee>> getEmployees()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;

        }
    }
}