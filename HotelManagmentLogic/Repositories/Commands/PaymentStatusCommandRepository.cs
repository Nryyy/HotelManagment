using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.IRepoository.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Repositories.Commands
{
    public class PaymentStatusCommandRepository : IPaymentStatusCommandRepository
    {
        private readonly HotelDBContext _context;

        public PaymentStatusCommandRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(PaymentStatus paymentStatus)
        {
            await _context.PaymentStatuses.AddAsync(paymentStatus);
        }

        public async Task UpdateAsync(PaymentStatus paymentStatus)
        {
            _context.PaymentStatuses.Update(paymentStatus);
        }

        public async Task DeleteAsync(int id)
        {
            var paymentStatus = await _context.PaymentStatuses.FindAsync(id);
            if (paymentStatus != null)
            {
                _context.PaymentStatuses.Remove(paymentStatus);
            }
        }
    }
}
