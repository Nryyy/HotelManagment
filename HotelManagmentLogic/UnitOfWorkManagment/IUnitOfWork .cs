using HotelManagmentLogic.Interfaces.IRepoository.Commands;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.UnitOfWorkManagment
{
    public interface IUnitOfWork : IDisposable
    {
        // GUEST BLOCK
        IGuestQueryRepository GuestQueryRepository { get; }
        IGuestCommandRepository GuestCommandRepository { get; }

        // EMPLOYEE BLOCK
        IEmployeeQueryRepository EmployeeQueryRepository { get; }
        IEmployeeCommandRepository EmployeeCommandRepository { get; }

        // ROLE BLOCK
        IRoleQueryRepository RoleQueryRepository { get; }
        IRoleCommandRepository RoleCommandRepository { get; }

        Task<int> CompleteAsync();
    }
}
