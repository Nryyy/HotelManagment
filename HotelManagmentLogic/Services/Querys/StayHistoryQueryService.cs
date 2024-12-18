using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class StayHistoryQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StayHistoryQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StayHistory>> GetAllStayHistoryAsync()
        {
            return await _unitOfWork.StayHistoryQueryRepository.GetAllAsync();
        }


        public async Task<StayHistory> GetStayHistoryByIdAsync(int id)
        {
            return await _unitOfWork.StayHistoryQueryRepository.GetByIdAsync(id);
        }
    }
}
