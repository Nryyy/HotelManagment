using ApplicationManagment.Interfaces.IRepoository.Commands;
using ApplicationManagment.Interfaces.IRepoository.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagment.UnitOfWorkManagment
{
    public interface IUnitOfWork : IDisposable
    {
        IGuestQueryRepository GuestQueryRepository { get; }
        IGuestCommandRepository GuestCommandRepository { get; }

        Task<int> CompleteAsync();
    }
}
