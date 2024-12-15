using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class EmployeeAction
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string ActionDescription { get; set; }
        public DateTime ActionDate { get; set; }

        public Employee Employee { get; set; }
    }
}
