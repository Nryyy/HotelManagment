using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class BookingPayment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int PaymentDay { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaymentStatusId { get; set; }

        public Booking Booking { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
