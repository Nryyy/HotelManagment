using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Employee
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<EmployeeAction> EmployeeActions { get; set; }
    }
}
