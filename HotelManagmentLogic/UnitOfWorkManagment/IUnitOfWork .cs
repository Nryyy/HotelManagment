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
        IGuestQueryRepository GuestQueryRepository { get; }
        IGuestCommandRepository GuestCommandRepository { get; }

        Task<int> CompleteAsync();
    }
}
