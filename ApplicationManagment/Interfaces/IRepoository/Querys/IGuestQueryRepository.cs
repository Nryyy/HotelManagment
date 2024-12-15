using EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagment.Interfaces.IRepoository.Querys
{
    public interface IGuestQueryRepository
    {
        Task<Guest> GetGuestByIdAsync(int id);
        Task<IEnumerable<Guest>> GetAllGuestsAsync();
    }
}
