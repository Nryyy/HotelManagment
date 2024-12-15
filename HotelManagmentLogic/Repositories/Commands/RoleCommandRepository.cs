using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.IRepoository.Commands;
using Enteties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Repositories.Commands
{
    public class RoleCommandRepository : IRoleCommandRepository
    {
        private readonly HotelDBContext _context;

        public RoleCommandRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Role role)
        {
            await _context.Roles.AddAsync(role);
        }

        public async Task UpdateAsync(Role role)
        {
            _context.Roles.Update(role);
        }

        public async Task DeleteAsync(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
            }
        }
    }
}
