using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Services.Querys
{
    public class RoomcategoryQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomcategoryQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Category>> GetAllRoomCategories()
        {
            return await _unitOfWork.RoomCategoryQueryRepository.GetAllAsync();
        }
        public async Task<Category> GetRoomcategoryById(int id)
        {
            return await _unitOfWork.RoomCategoryQueryRepository.GetByIdAsync(id);
        }
    }
}
