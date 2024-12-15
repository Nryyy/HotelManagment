using ApplicationManagment.ApplicationContext;
using ApplicationManagment.Interfaces.IRepoository.Commands;
using EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagment.Repositories.Commands
{
    public class GuestCommandRepository : IGuestCommandRepository
    {
        private readonly HotelDBContext _context;

        public GuestCommandRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Guest guest)
        {
            await _context.Guests.AddAsync(guest);
        }

        public async Task UpdateAsync(Guest guest)
        {
            _context.Guests.Update(guest);
        }

        public async Task DeleteAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
            }
        }
    }
}
