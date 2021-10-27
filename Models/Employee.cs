using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTS.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int Gender { get; set; }
        public int depatmentId { get; set; }
        public string departmentName { get; set; }
        public string photopath { get; set; }

    }
}