using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class EmploteeActionQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmploteeActionQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<EmployeeAction>> GetAllEmployeeActionsAsync()
        {
            return await _unitOfWork.EmployeeActionQueryRepository.GetAllAsync();
        }

        public async Task<EmployeeAction> GetEmployeeActionByIdAsync(int id)
        {
            return await _unitOfWork.EmployeeActionQueryRepository.GetByIdAsync(id);
        }
    }
}
