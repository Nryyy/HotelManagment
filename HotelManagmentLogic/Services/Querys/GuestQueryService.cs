using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class GuestQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GuestQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _unitOfWork.GuestQueryRepository.GetGuestByIdAsync(id);
        }

        public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
        {
            return await _unitOfWork.GuestQueryRepository.GetAllGuestsAsync();
        }
    }
}
