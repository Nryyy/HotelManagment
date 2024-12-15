using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Interfaces.IRepoository.Querys
{
    public interface IRoleQueryRepository
    {
        Task<Role> GetRoleByIdAsync(int id);
        Task<IEnumerable<Role>> GetAllRoleAsync();
    }
}
