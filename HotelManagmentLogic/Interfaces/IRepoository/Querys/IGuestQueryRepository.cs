using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Interfaces.IRepoository.Querys
{
    public interface IGuestQueryRepository
    {
        Task<Guest> GetGuestByIdAsync(int id);
        Task<IEnumerable<Guest>> GetAllGuestsAsync();
    }
}
