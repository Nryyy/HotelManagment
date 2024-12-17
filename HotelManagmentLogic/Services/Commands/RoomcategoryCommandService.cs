using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using HotelManagmentLogic.UnitOfWorkManagment;

namespace HotelManagmentLogic.Services.Commands
{
    public class RoomcategoryCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomcategoryCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddRoomcategoryAsync(Category roomcategory)
        {
            await _unitOfWork.RoomCategoryCommandRepository.AddAsync(roomcategory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateRoomcategoryAsync(Category roomcategory)
        {
            _unitOfWork.RoomCategoryCommandRepository.UpdateAsync(roomcategory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteRoomcategoryAsync(int id)
        {
            await _unitOfWork.RoomCategoryCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
