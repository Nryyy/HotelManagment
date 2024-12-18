using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Services.Querys
{
    public class BookingStatusQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingStatusQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BookingStatus> GetBookingStatusByIdAsync(int id)
        {
            return await _unitOfWork.BookingStatusQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<BookingStatus>> GetAllBookingStatusAsync()
        {
            return await _unitOfWork.BookingStatusQueryRepository.GetAllAsync();
        }
    }
}
