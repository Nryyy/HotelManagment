using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Interfaces.IRepoository.Commands
{
    public interface IRoleCommandRepository
    {
        Task AddAsync(Role role);
        Task UpdateAsync(Role role);
        Task DeleteAsync(int id);
    }
}
