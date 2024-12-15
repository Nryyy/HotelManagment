using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime BookingDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }

        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public BookingStatus Status { get; set; }
        public ICollection<BookingPayment> Payments { get; set; }
    }
}
