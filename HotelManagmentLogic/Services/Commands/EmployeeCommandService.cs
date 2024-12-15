using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class EmployeeCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _unitOfWork.EmployeeCommandRepository.AddAsync(employee);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _unitOfWork.EmployeeCommandRepository.UpdateAsync(employee);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _unitOfWork.EmployeeCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
