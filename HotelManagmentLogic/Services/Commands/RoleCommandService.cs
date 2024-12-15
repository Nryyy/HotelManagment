using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Services.Commands
{
    public class RoleCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddRoleAsync(Role role)
        {
            await _unitOfWork.RoleCommandRepository.AddAsync(role);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            _unitOfWork.RoleCommandRepository.UpdateAsync(role);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteRoleAsync(int id)
        {
            await _unitOfWork.RoleCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
