using ApplicationManagment.ApplicationContext;
using ApplicationManagment.Interfaces.IRepoository.Querys;
using EntityClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagment.Repositories.Querys
{
    public class GuestQueryRepository : IGuestQueryRepository
    {
        private readonly HotelDBContext _context;

        public GuestQueryRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _context.Guests.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
        {
            return await _context.Guests.ToListAsync();
        }
    }
}
