using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class BookingPaymentQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingPaymentQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Enteties.BookingPayment> GetBookingPaymentByIdAsync(int id)
        {
            return await _unitOfWork.BookingPaymentQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Enteties.BookingPayment>> GetAllBookingPaymentsAsync()
        {
            return await _unitOfWork.BookingPaymentQueryRepository.GetAllAsync();
        }
    }
}
