using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class EmployeeActionCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeActionCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddEmployeeActionAsync(EmployeeAction employeeAction)
        {
            await _unitOfWork.EmployeeActionCommandRepository.AddAsync(employeeAction);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateEmployeeActionAsync(EmployeeAction employeeAction)
        {
            await _unitOfWork.EmployeeActionCommandRepository.UpdateAsync(employeeAction);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteEmployeeActionAsync(int id)
        {
            await _unitOfWork.EmployeeActionCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
