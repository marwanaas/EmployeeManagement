using Employeemanagmenet.model;
using Employeemanagmenet.model.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class EmployeelistBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = new List<Employee>();
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
       
       

        }
    } 


