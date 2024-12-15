using HotelManagmentLogic.UnitOfWorkManagment;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class RoleQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _unitOfWork.RoleQueryRepository.GetRoleByIdAsync(id);
        }

        public Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return _unitOfWork.RoleQueryRepository.GetAllRoleAsync();
        }
    }
}
