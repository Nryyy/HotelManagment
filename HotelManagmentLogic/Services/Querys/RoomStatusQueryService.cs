using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class RoomStatusQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomStatusQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Enteties.RoomStatus> GetRoomStatusByIdAsync(int id)
        {
            return await _unitOfWork.RoomStatusQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Enteties.RoomStatus>> GetAllRoomStatusesAsync()
        {
            return await _unitOfWork.RoomStatusQueryRepository.GetAllAsync();
        }
    }
}
