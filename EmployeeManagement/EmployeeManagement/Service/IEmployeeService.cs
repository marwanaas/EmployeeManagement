using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Employeemanagmenet.model.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>>GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<HttpResponseMessage> UpdateEmployee(Employee updateEmployee);
        Task<HttpResponseMessage> CreateEmployee(Employee NewEmployee);
        Task DeleteEmployee(int id);
    }
}
