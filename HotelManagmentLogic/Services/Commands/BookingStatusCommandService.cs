using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Services.Commands
{
    public class BookingStatusCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingStatusCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookingStatus(BookingStatus bookingStatus)
        {
            await _unitOfWork.BookingStatusCommandRepository.AddAsync(bookingStatus);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateBookingStatus(BookingStatus bookingStatus)
        {
            await _unitOfWork.BookingStatusCommandRepository.UpdateAsync(bookingStatus);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookingStatus(int id)
        {
            await _unitOfWork.BookingStatusCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
