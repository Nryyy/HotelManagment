using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class BookingPaymentCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingPaymentCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookingPaymentAsync(BookingPayment bookingPayment)
        {
            await _unitOfWork.BookingPaymentCommandRepository.AddAsync(bookingPayment);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateBookingPaymentAsync(BookingPayment bookingPayment)
        {
            _unitOfWork.BookingPaymentCommandRepository.UpdateAsync(bookingPayment);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookingPaymentAsync(int id)
        {
            await _unitOfWork.BookingPaymentCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
