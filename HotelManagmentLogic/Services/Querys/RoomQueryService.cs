using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class RoomQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _unitOfWork.RoomQueryRepository.GetAllAsync();
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _unitOfWork.RoomQueryRepository.GetByIdAsync(id);
        }
    }
}
