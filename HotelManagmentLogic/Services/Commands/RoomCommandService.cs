using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using HotelManagmentLogic.UnitOfWorkManagment;

namespace HotelManagmentLogic.Services.Commands
{
    public class RoomCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddRoomAsync(Room room)
        {
            await _unitOfWork.RoomCommandRepository.AddAsync(room);
            await _unitOfWork.CompleteAsync();
        }
        public async Task UpdateRoom(Room room)
        {
            await _unitOfWork.RoomCommandRepository.UpdateAsync(room);
            await _unitOfWork.CompleteAsync();
        }
        public async Task DeleteRoom(int id)
        {
            await _unitOfWork.RoomCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
