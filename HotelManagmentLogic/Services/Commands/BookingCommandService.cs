using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class BookingCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            await _unitOfWork.BookingCommandRepository.AddAsync(booking);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            await _unitOfWork.BookingCommandRepository.UpdateAsync(booking);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookingAsync(int id)
        {
            await _unitOfWork.BookingCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
