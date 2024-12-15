using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class BookingStatusHistory
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int PreviousStatusId { get; set; }
        public int NewStatusId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ChangedByEmployeeId { get; set; }

        public Booking Booking { get; set; }
        public Employee ChangedByEmployee { get; set; }
    }
}
