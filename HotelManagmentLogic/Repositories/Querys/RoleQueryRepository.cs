using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using Microsoft.EntityFrameworkCore;

namespace HotelManagmentLogic.Repositories.Querys
{
    public class RoleQueryRepository : IRoleQueryRepository
    {
        private readonly HotelDBContext _context;

        public RoleQueryRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _context.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Role>> GetAllRoleAsync()
        {
            return await _context.Roles.ToListAsync();
        }
    }
}
