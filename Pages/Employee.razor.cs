using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using latihan_blazor.Models;

namespace latihan_blazor.Pages
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Micho",
                LastName="Vincent",
                Email="michovincent@si.ukdw.ac.id",
                DateOfBirth = new DateTime(1999,12,23),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="Bussiness Analyst"},
                PhotoPath = "images/mivi.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Farel",
                LastName="Karel",
                Email="farelrun@yahoo.com",
                DateOfBirth = new DateTime(1998,10,13),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="Bussiness Analyst"},
                PhotoPath = "images/farel.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Jasmine",
                LastName="Violet",
                Email="violetjasmine@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2001,11,21),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=3,DepartmentName="Data Analyst"},
                PhotoPath = "images/violet.jpg"
                   };
            
            Employee e4 = new Employee{
                EmployeeId=4,
                FirstName="Katherine",
                LastName="Gabriel",
                Email="gabriel09@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2002,09,09),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=4,DepartmentName="Data Analyst"},
                PhotoPath = "images/Gabriel.jpg"
                };


                   Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }
}