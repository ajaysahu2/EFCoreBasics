using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //One-to-many relationship with Employee
        public ICollection<Employee> Employees { get; set; }//Collection navigation property to represent employee
    }
}
