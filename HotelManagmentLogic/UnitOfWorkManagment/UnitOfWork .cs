using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.IRepoository.Commands;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;
using HotelManagmentLogic.Repositories.Commands;
using HotelManagmentLogic.Repositories.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.UnitOfWorkManagment
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelDBContext _context;
        // GUEST SECTION
        private IGuestQueryRepository _guestQueryRepository;
        private IGuestCommandRepository _guestCommandRepository;

        public UnitOfWork(HotelDBContext context)
        {
            _context = context;
        }

        public IGuestQueryRepository GuestQueryRepository
        {
            get
            {
                if (_guestQueryRepository == null)
                {
                    _guestQueryRepository = new GuestQueryRepository(_context);
                }
                return _guestQueryRepository;
            }
        }

        public IGuestCommandRepository GuestCommandRepository
        {
            get
            {
                if (_guestCommandRepository == null)
                {
                    _guestCommandRepository = new GuestCommandRepository(_context);
                }
                return _guestCommandRepository;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
