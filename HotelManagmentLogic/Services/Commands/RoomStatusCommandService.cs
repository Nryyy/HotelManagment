using System;
using Enteties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagmentLogic.UnitOfWorkManagment;

namespace HotelManagmentLogic.Services.Commands
{
    public class RoomStatusCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomStatusCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddRoomStatus(RoomStatus roomStatus)
        {
            await _unitOfWork.RoomStatusCommandRepository.AddAsync(roomStatus);
            await _unitOfWork.CompleteAsync();
        }
        public async Task UpdateRoomStatus(RoomStatus roomStatus)
        {
            _unitOfWork.RoomStatusCommandRepository.UpdateAsync(roomStatus);
            await _unitOfWork.CompleteAsync();
        }
        public async Task DeleteRoomStatus(int id)
        {
            await _unitOfWork.RoomStatusCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
