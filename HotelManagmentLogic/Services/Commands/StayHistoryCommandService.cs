using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class StayHistoryCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StayHistoryCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddStayHostoryAsync(StayHistory stayHostory)
        {
            await _unitOfWork.StayHistoryCommandRepository.AddAsync(stayHostory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateStayHostoryAsync(StayHistory stayHostory)
        {
            await _unitOfWork.StayHistoryCommandRepository.UpdateAsync(stayHostory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteStayHostoryAsync(int id)
        {
            await _unitOfWork.StayHistoryCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
