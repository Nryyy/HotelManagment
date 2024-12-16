using HotelManagmentLogic.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using Microsoft.EntityFrameworkCore;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;

namespace HotelManagmentLogic.Repositories.Querys
{
    public class PaymentStatusQueryRepository : IPaymentStatusQueryRepository
    {
        private readonly HotelDBContext _context;

        public PaymentStatusQueryRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<PaymentStatus> GetPaymentStatusByIdAsync(int id)
        {
            return await _context.PaymentStatuses.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<PaymentStatus>> GetAllPaymentStatusAsync()
        {
            return await _context.PaymentStatuses.ToListAsync();
        }
    }
}
