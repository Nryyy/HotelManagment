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

        // EMPLOYEE SECTION
        private IEmployeeQueryRepository _employeeQueryRepository;
        private IEmployeeCommandRepository _employeeCommandRepository;

        // ROLE SECTION
        private IRoleQueryRepository _roleQueryRepository;
        private IRoleCommandRepository _roleCommandRepository;

        public UnitOfWork(HotelDBContext context)
        {
            _context = context;
        }


        // GUEST BLOCK
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

        // EMPLOYEE BLOCK
        public IEmployeeQueryRepository EmployeeQueryRepository
        {
            get
            {
                if (_employeeQueryRepository == null)
                {
                    _employeeQueryRepository = new EmployeeQueryRepository(_context);
                }
                return _employeeQueryRepository;
            }
        }

        public IEmployeeCommandRepository EmployeeCommandRepository
        {
            get
            {
                if (_employeeCommandRepository == null)
                {
                    _employeeCommandRepository = new EmployeeCommandRepository(_context);
                }
                return _employeeCommandRepository;
            }
        }

        // ROLE BLOCK
        public IRoleQueryRepository RoleQueryRepository
        {
            get
            {
                if (_roleQueryRepository == null)
                {
                    _roleQueryRepository = new RoleQueryRepository(_context);
                }
                return _roleQueryRepository;
            }
        }

        public IRoleCommandRepository RoleCommandRepository
        {
            get
            {
                if (_roleCommandRepository == null)
                {
                    _roleCommandRepository = new RoleCommandRepository(_context);
                }
                return _roleCommandRepository;
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
