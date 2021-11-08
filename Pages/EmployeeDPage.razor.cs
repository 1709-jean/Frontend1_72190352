using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UTS.Models;
using UTS.Services;

namespace UTS.Pages
{
    public partial class EmployeeDPage
    {
        public IEnumerable<Employee> Employees {get; set;}
        [Inject]
        public IEmployeeDServices EmployeeDServices{get; set;}
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDServices.GetEmployees()).ToList();
        }
        
        
    }
}