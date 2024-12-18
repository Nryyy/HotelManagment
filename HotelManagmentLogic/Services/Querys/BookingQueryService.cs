using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class BookingQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _unitOfWork.BookingQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _unitOfWork.BookingQueryRepository.GetAllAsync();
        }
    }
}
