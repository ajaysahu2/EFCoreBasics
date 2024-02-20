using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        //One-To-One relationship with EmployeeDetails
        //public EmployeeDetails EmployeeDetails { get; set; }//Refrence navigation to dependent entity-EmployeeDetails

        public ICollection<EmployeeProject>EmployeeProjects { get; set; } //Collection navigation property
    }
}
