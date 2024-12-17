using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class EmployeeQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Enteties.Employee> GetEmployeeByIdAsync(int id)
        {
            return await _unitOfWork.EmployeeQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Enteties.Employee>> GetAllEmployeesAsync()
        {
            return await _unitOfWork.EmployeeQueryRepository.GetAllAsync();
        }
    }
}
